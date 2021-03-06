﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace Planner
{
    public partial class AddClassForm : Form
    {
        #region Fields
        //grading scale information
        AddGradingScaleForm addGradingScale = new AddGradingScaleForm();
        AddGradeCategoriesForm addGradeCategories = new AddGradeCategoriesForm();
        private List<string> categories = new List<string>();
        private List<double> percentages = new List<double>();
        private List<string> methods = new List<string>();

        //list of professors id
        private List<int> profId = new List<int>();
        private List<int> semesterId = new List<int>();
        #endregion

        #region Constructor
        public AddClassForm()
        {
            InitializeComponent();

            //dynamically add professors to combo box
            Util.addProfessors(cbClassProfessor, profId, false, false, null, null);

            //dynamically add possible grades
            Util.addLetterGrades(cbFinalLetterGrade);

            //dynamically add possible semesters
            Util.addSemesters(cbSemester, semesterId, false);
        }
        #endregion

        #region Events
        //event handler for whether the class is finished
        private void chkClassFinished_CheckedChanged(object sender, EventArgs e) {
            //if class is finished allow user to enter final grade
            if (chkClassFinished.Checked == true) {
                cbFinalLetterGrade.Enabled = true;
            }
            else {
                cbFinalLetterGrade.Enabled = false;
                cbFinalLetterGrade.SelectedIndex = -1;
            }
        }
        
        private void btnSaveClass_Click(object sender, EventArgs e) {
            //save class information and close form if successful
            if (saveClass() == true) {
                Close();
            }
        }

        private void btnCloseClass_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddAnotherClass_Click(object sender, EventArgs e) {
            //reset form to default values if save was successful
            if (saveClass() == true) {
                txtClassName.ResetText();
                cbClassProfessor.SelectedIndex = -1;
                ctrCredits.Value = 0;
                chkClassMonday.Checked = false;
                chkClassTuesday.Checked = false;
                chkClassWednesday.Checked = false;
                chkClassThursday.Checked = false;
                chkClassFriday.Checked = false;
                txtClassLocation.ResetText();
                dtClassStartTime.Value = new DateTime(2000, 1, 1, 11, 0, 0);
                dtClassEndTime.Value = new DateTime(2000, 1, 1, 12, 0, 0);
                cbSemester.SelectedIndex = -1;
                cbFinalLetterGrade.SelectedItem = null;
                chkClassFinished.Checked = false;
                lnkAddGradingCategories.Enabled = true;
                addGradingScale = new AddGradingScaleForm();
                addGradeCategories = new AddGradeCategoriesForm();
            }
        }

        private void dtClassStartTime_ValueChanged(object sender, EventArgs e) {
            //update end time to one hour after start time when user changes start time
            dtClassEndTime.Value = new DateTime(2000, 1, 1, (dtClassStartTime.Value.Hour + 1) % 24, dtClassStartTime.Value.Minute % 60, 0);
        }

        private void lnkAddGradingScale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //show the grading scale form and once it is closed, get the grading scale information
            addGradingScale.ShowDialog();
            GradingScale.changeValues(addGradingScale.getGradingScale());
        }

        private void lnkAddGradingCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //show the grade category form and once it is closed, get the grade category information
            addGradeCategories.ShowDialog();
            categories = addGradeCategories.getCategories();
            percentages = addGradeCategories.getPercentages();
            methods = addGradeCategories.getMethods();
        }
        #endregion

        #region Methods
        //saves the class information, returning true if successful and false if there was an error
        private bool saveClass()
        {

            if (checkingClassNames())
            {
                return raiseInvalidClassNameError();
            }

            if (chkClassFinished.Checked == false && categories.Count == 0)
            {
                return raiseInvalidGradeCategory();
            }
            if (dtClassStartTime.Value.TimeOfDay > dtClassEndTime.Value.TimeOfDay)
            {
                return rasiInavlidTimeErorr();
            }
            string currentGrade = "null";
            if (chkClassFinished.Checked)
            {
                //make sure user has selected a value
                if (cbFinalLetterGrade.Equals(""))
                {
                    return raiseInvalidLetterGradeError();
                }
                currentGrade = "'" + cbFinalLetterGrade.Text + "'";
            }
            string semesterIdValue = "null";
            if (cbSemester.SelectedIndex >= 0)
            {
                semesterIdValue = "'" + semesterId[cbSemester.SelectedIndex] + "'";
            }
            insertIntoDB(currentGrade, semesterIdValue);
            clearArrays();
            return true;
        }

        private void insertIntoDB(string currentGrade, string semesterIdValue)
        {
            //begin database transaction
            Database.beginTransaction();

            Database.modifyDatabase(
                string.Format(@"INSERT INTO Class VALUES (null, {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',{7}, TIME('{8}'), TIME('{9}'),
                                 {10}, null, null,{11});", Util.quote(txtClassName.Text), ctrCredits.Value, chkClassMonday.Checked, chkClassTuesday.Checked,
                                 chkClassWednesday.Checked, chkClassThursday.Checked, chkClassFriday.Checked, semesterIdValue, dtClassStartTime.Value.TimeOfDay,
                                 dtClassEndTime.Value.TimeOfDay, Util.quote(txtClassLocation.Text), currentGrade));

            //get the id of the value just inserted
            object classID = Database.getInsertedID();

            //insert into database the class professor assignment
            if (cbClassProfessor.SelectedIndex >= 0)
            {
                Database.modifyDatabase(
                    string.Format("INSERT INTO ClassProfessor VALUES ('{0}', '{1}');", profId[cbClassProfessor.SelectedIndex], classID)
                    );
            }

            //insert grading scale
            for (int i = 0; i < GradingScale.Length; i++)
            {

                Database.modifyDatabase(
                    string.Format("INSERT INTO GradingScaleValue VALUES('{0}', '{1}', '{2}');", GradeLetter.code(i).ToString(), classID, GradingScale.code(i).ToInteger())
                    );
            }

            //add value for F
            Database.modifyDatabase(
                string.Format("INSERT INTO GradingScaleValue VALUES('F', '{0}', '0.00');", classID)
                );

            //insert grade category
            for (int i = 0; i < categories.Count; i++)
            {
                Database.modifyDatabase(
                    string.Format("INSERT INTO GradeCategory VALUES('{0}', '{1}', '{2}', null, '{3}');", categories[i], classID, methods[i], percentages[i])
                    );
            }

            //commit all inserts to database
            Database.commit();
        }

        private void clearArrays()
        {
            //clear all arrays after updating database
            categories.Clear();
            percentages.Clear();
            methods.Clear();
        }

        private bool checkingClassNames()
        {
            return txtClassName.Text.Equals("") || (chkClassMonday.Checked == false && chkClassTuesday.Checked == false) &&
                            chkClassWednesday.Checked == false && chkClassThursday.Checked == false && chkClassFriday.Checked == false ||
                            (chkClassFinished.Checked == true && cbFinalLetterGrade.Text.Equals(""));
        }

        private static bool raiseInvalidClassNameError()
        {
            Util.displayRequiredFieldsError(new string[] { "Class Name", "Days" });
            return false;
        }

        private static bool raiseInvalidGradeCategory()
        {
            Util.displayRequiredFieldsError("Grade Categories");
            return false;
        }

        private static bool rasiInavlidTimeErorr()
        {
            Util.displayError("Invalid Start and End Times", "Error");
            return false;
        }

        private static bool raiseInvalidLetterGradeError()
        {
            Util.displayError("Please select a valid letter grade for the class", "Invalid Letter Grade");
            return false;
        }
        #endregion
    }
}
