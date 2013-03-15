﻿namespace Planner
{
    partial class EditOfficeHoursForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOfficeHoursForm));
            this.btnDeleteOfficeHours = new System.Windows.Forms.Button();
            this.lnkAddOfficeHours = new System.Windows.Forms.LinkLabel();
            this.lnkPreviousOfficeHours = new System.Windows.Forms.LinkLabel();
            this.lnkNextOfficeHours = new System.Windows.Forms.LinkLabel();
            this.lblOfficeHoursText = new System.Windows.Forms.Label();
            this.lblRequiredOfficeHours3 = new System.Windows.Forms.Label();
            this.lblRequiredOfficeHours2 = new System.Windows.Forms.Label();
            this.chkOfficeHoursFri = new System.Windows.Forms.CheckBox();
            this.dtOfficeHoursEnd = new System.Windows.Forms.DateTimePicker();
            this.lblOfficeHoursEndTime = new System.Windows.Forms.Label();
            this.chkOfficeHoursThu = new System.Windows.Forms.CheckBox();
            this.chkOfficeHoursWed = new System.Windows.Forms.CheckBox();
            this.chkOfficeHoursTue = new System.Windows.Forms.CheckBox();
            this.chkOfficeHoursMon = new System.Windows.Forms.CheckBox();
            this.dtOfficeHoursStart = new System.Windows.Forms.DateTimePicker();
            this.btnOfficeHoursClose = new System.Windows.Forms.Button();
            this.btnOfficeHoursSave = new System.Windows.Forms.Button();
            this.lblRequiredOfficeHours1 = new System.Windows.Forms.Label();
            this.lblOfficeHoursStartTime = new System.Windows.Forms.Label();
            this.lblOfficeHourDays = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDeleteOfficeHours
            // 
            this.btnDeleteOfficeHours.AutoSize = true;
            this.btnDeleteOfficeHours.Location = new System.Drawing.Point(146, 293);
            this.btnDeleteOfficeHours.Name = "btnDeleteOfficeHours";
            this.btnDeleteOfficeHours.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteOfficeHours.TabIndex = 12;
            this.btnDeleteOfficeHours.Text = "Delete";
            this.btnDeleteOfficeHours.UseVisualStyleBackColor = true;
            this.btnDeleteOfficeHours.Click += new System.EventHandler(this.btnDeleteOfficeHours_Click);
            // 
            // lnkAddOfficeHours
            // 
            this.lnkAddOfficeHours.AutoSize = true;
            this.lnkAddOfficeHours.Location = new System.Drawing.Point(118, 234);
            this.lnkAddOfficeHours.Name = "lnkAddOfficeHours";
            this.lnkAddOfficeHours.Size = new System.Drawing.Size(123, 13);
            this.lnkAddOfficeHours.TabIndex = 9;
            this.lnkAddOfficeHours.TabStop = true;
            this.lnkAddOfficeHours.Text = "Add Another Office Hour";
            this.lnkAddOfficeHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddOfficeHours_LinkClicked);
            // 
            // lnkPreviousOfficeHours
            // 
            this.lnkPreviousOfficeHours.AutoSize = true;
            this.lnkPreviousOfficeHours.Location = new System.Drawing.Point(54, 234);
            this.lnkPreviousOfficeHours.Name = "lnkPreviousOfficeHours";
            this.lnkPreviousOfficeHours.Size = new System.Drawing.Size(48, 13);
            this.lnkPreviousOfficeHours.TabIndex = 8;
            this.lnkPreviousOfficeHours.TabStop = true;
            this.lnkPreviousOfficeHours.Text = "Previous";
            this.lnkPreviousOfficeHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPreviousOfficeHours_LinkClicked);
            // 
            // lnkNextOfficeHours
            // 
            this.lnkNextOfficeHours.AutoSize = true;
            this.lnkNextOfficeHours.Location = new System.Drawing.Point(259, 234);
            this.lnkNextOfficeHours.Name = "lnkNextOfficeHours";
            this.lnkNextOfficeHours.Size = new System.Drawing.Size(29, 13);
            this.lnkNextOfficeHours.TabIndex = 10;
            this.lnkNextOfficeHours.TabStop = true;
            this.lnkNextOfficeHours.Text = "Next";
            this.lnkNextOfficeHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNextOfficeHours_LinkClicked);
            // 
            // lblOfficeHoursText
            // 
            this.lblOfficeHoursText.AutoSize = true;
            this.lblOfficeHoursText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeHoursText.Location = new System.Drawing.Point(12, 9);
            this.lblOfficeHoursText.Name = "lblOfficeHoursText";
            this.lblOfficeHoursText.Size = new System.Drawing.Size(208, 17);
            this.lblOfficeHoursText.TabIndex = 30;
            this.lblOfficeHoursText.Text = "Edit the professor\'s office hours";
            this.lblOfficeHoursText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequiredOfficeHours3
            // 
            this.lblRequiredOfficeHours3.AutoSize = true;
            this.lblRequiredOfficeHours3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredOfficeHours3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredOfficeHours3.Location = new System.Drawing.Point(217, 197);
            this.lblRequiredOfficeHours3.Name = "lblRequiredOfficeHours3";
            this.lblRequiredOfficeHours3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredOfficeHours3.TabIndex = 29;
            this.lblRequiredOfficeHours3.Text = "*";
            // 
            // lblRequiredOfficeHours2
            // 
            this.lblRequiredOfficeHours2.AutoSize = true;
            this.lblRequiredOfficeHours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredOfficeHours2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredOfficeHours2.Location = new System.Drawing.Point(217, 163);
            this.lblRequiredOfficeHours2.Name = "lblRequiredOfficeHours2";
            this.lblRequiredOfficeHours2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredOfficeHours2.TabIndex = 28;
            this.lblRequiredOfficeHours2.Text = "*";
            // 
            // chkOfficeHoursFri
            // 
            this.chkOfficeHoursFri.AutoSize = true;
            this.chkOfficeHoursFri.Location = new System.Drawing.Point(130, 131);
            this.chkOfficeHoursFri.Name = "chkOfficeHoursFri";
            this.chkOfficeHoursFri.Size = new System.Drawing.Size(54, 17);
            this.chkOfficeHoursFri.TabIndex = 5;
            this.chkOfficeHoursFri.Text = "Friday";
            this.chkOfficeHoursFri.UseVisualStyleBackColor = true;
            // 
            // dtOfficeHoursEnd
            // 
            this.dtOfficeHoursEnd.CustomFormat = "hh:mm tt";
            this.dtOfficeHoursEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOfficeHoursEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOfficeHoursEnd.Location = new System.Drawing.Point(130, 194);
            this.dtOfficeHoursEnd.Name = "dtOfficeHoursEnd";
            this.dtOfficeHoursEnd.ShowUpDown = true;
            this.dtOfficeHoursEnd.Size = new System.Drawing.Size(83, 23);
            this.dtOfficeHoursEnd.TabIndex = 7;
            this.dtOfficeHoursEnd.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // lblOfficeHoursEndTime
            // 
            this.lblOfficeHoursEndTime.AutoSize = true;
            this.lblOfficeHoursEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeHoursEndTime.Location = new System.Drawing.Point(44, 196);
            this.lblOfficeHoursEndTime.Name = "lblOfficeHoursEndTime";
            this.lblOfficeHoursEndTime.Size = new System.Drawing.Size(81, 17);
            this.lblOfficeHoursEndTime.TabIndex = 25;
            this.lblOfficeHoursEndTime.Text = "End Time:";
            // 
            // chkOfficeHoursThu
            // 
            this.chkOfficeHoursThu.AutoSize = true;
            this.chkOfficeHoursThu.Location = new System.Drawing.Point(130, 108);
            this.chkOfficeHoursThu.Name = "chkOfficeHoursThu";
            this.chkOfficeHoursThu.Size = new System.Drawing.Size(70, 17);
            this.chkOfficeHoursThu.TabIndex = 4;
            this.chkOfficeHoursThu.Text = "Thursday";
            this.chkOfficeHoursThu.UseVisualStyleBackColor = true;
            // 
            // chkOfficeHoursWed
            // 
            this.chkOfficeHoursWed.AutoSize = true;
            this.chkOfficeHoursWed.Location = new System.Drawing.Point(130, 85);
            this.chkOfficeHoursWed.Name = "chkOfficeHoursWed";
            this.chkOfficeHoursWed.Size = new System.Drawing.Size(83, 17);
            this.chkOfficeHoursWed.TabIndex = 3;
            this.chkOfficeHoursWed.Text = "Wednesday";
            this.chkOfficeHoursWed.UseVisualStyleBackColor = true;
            // 
            // chkOfficeHoursTue
            // 
            this.chkOfficeHoursTue.AutoSize = true;
            this.chkOfficeHoursTue.Location = new System.Drawing.Point(130, 62);
            this.chkOfficeHoursTue.Name = "chkOfficeHoursTue";
            this.chkOfficeHoursTue.Size = new System.Drawing.Size(67, 17);
            this.chkOfficeHoursTue.TabIndex = 2;
            this.chkOfficeHoursTue.Text = "Tuesday";
            this.chkOfficeHoursTue.UseVisualStyleBackColor = true;
            // 
            // chkOfficeHoursMon
            // 
            this.chkOfficeHoursMon.AutoSize = true;
            this.chkOfficeHoursMon.Location = new System.Drawing.Point(130, 39);
            this.chkOfficeHoursMon.Name = "chkOfficeHoursMon";
            this.chkOfficeHoursMon.Size = new System.Drawing.Size(64, 17);
            this.chkOfficeHoursMon.TabIndex = 1;
            this.chkOfficeHoursMon.Text = "Monday";
            this.chkOfficeHoursMon.UseVisualStyleBackColor = true;
            // 
            // dtOfficeHoursStart
            // 
            this.dtOfficeHoursStart.CustomFormat = "hh:mm tt";
            this.dtOfficeHoursStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOfficeHoursStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOfficeHoursStart.Location = new System.Drawing.Point(130, 160);
            this.dtOfficeHoursStart.Name = "dtOfficeHoursStart";
            this.dtOfficeHoursStart.ShowUpDown = true;
            this.dtOfficeHoursStart.Size = new System.Drawing.Size(83, 23);
            this.dtOfficeHoursStart.TabIndex = 6;
            this.dtOfficeHoursStart.Value = new System.DateTime(2000, 1, 1, 11, 0, 0, 0);
            this.dtOfficeHoursStart.ValueChanged += new System.EventHandler(this.dtOfficeHoursStart_ValueChanged);
            // 
            // btnOfficeHoursClose
            // 
            this.btnOfficeHoursClose.AutoSize = true;
            this.btnOfficeHoursClose.Location = new System.Drawing.Point(252, 293);
            this.btnOfficeHoursClose.Name = "btnOfficeHoursClose";
            this.btnOfficeHoursClose.Size = new System.Drawing.Size(75, 23);
            this.btnOfficeHoursClose.TabIndex = 13;
            this.btnOfficeHoursClose.Text = "Close";
            this.btnOfficeHoursClose.UseVisualStyleBackColor = true;
            this.btnOfficeHoursClose.Click += new System.EventHandler(this.btnOfficeHoursClose_Click);
            // 
            // btnOfficeHoursSave
            // 
            this.btnOfficeHoursSave.AutoSize = true;
            this.btnOfficeHoursSave.Location = new System.Drawing.Point(27, 293);
            this.btnOfficeHoursSave.Name = "btnOfficeHoursSave";
            this.btnOfficeHoursSave.Size = new System.Drawing.Size(98, 23);
            this.btnOfficeHoursSave.TabIndex = 11;
            this.btnOfficeHoursSave.Text = "Save And Close";
            this.btnOfficeHoursSave.UseVisualStyleBackColor = true;
            this.btnOfficeHoursSave.Click += new System.EventHandler(this.btnOfficeHoursSave_Click);
            // 
            // lblRequiredOfficeHours1
            // 
            this.lblRequiredOfficeHours1.AutoSize = true;
            this.lblRequiredOfficeHours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredOfficeHours1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredOfficeHours1.Location = new System.Drawing.Point(198, 39);
            this.lblRequiredOfficeHours1.Name = "lblRequiredOfficeHours1";
            this.lblRequiredOfficeHours1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredOfficeHours1.TabIndex = 17;
            this.lblRequiredOfficeHours1.Text = "*";
            // 
            // lblOfficeHoursStartTime
            // 
            this.lblOfficeHoursStartTime.AutoSize = true;
            this.lblOfficeHoursStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeHoursStartTime.Location = new System.Drawing.Point(37, 163);
            this.lblOfficeHoursStartTime.Name = "lblOfficeHoursStartTime";
            this.lblOfficeHoursStartTime.Size = new System.Drawing.Size(88, 17);
            this.lblOfficeHoursStartTime.TabIndex = 6;
            this.lblOfficeHoursStartTime.Text = "Start Time:";
            // 
            // lblOfficeHourDays
            // 
            this.lblOfficeHourDays.AutoSize = true;
            this.lblOfficeHourDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeHourDays.Location = new System.Drawing.Point(64, 38);
            this.lblOfficeHourDays.Name = "lblOfficeHourDays";
            this.lblOfficeHourDays.Size = new System.Drawing.Size(61, 17);
            this.lblOfficeHourDays.TabIndex = 3;
            this.lblOfficeHourDays.Text = "Day(s):";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(80, 263);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSaveStatus.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // EditOfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 332);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.btnDeleteOfficeHours);
            this.Controls.Add(this.lnkAddOfficeHours);
            this.Controls.Add(this.lblOfficeHoursText);
            this.Controls.Add(this.lnkPreviousOfficeHours);
            this.Controls.Add(this.lblOfficeHourDays);
            this.Controls.Add(this.lnkNextOfficeHours);
            this.Controls.Add(this.lblOfficeHoursStartTime);
            this.Controls.Add(this.lblRequiredOfficeHours1);
            this.Controls.Add(this.lblRequiredOfficeHours3);
            this.Controls.Add(this.btnOfficeHoursSave);
            this.Controls.Add(this.lblRequiredOfficeHours2);
            this.Controls.Add(this.btnOfficeHoursClose);
            this.Controls.Add(this.chkOfficeHoursFri);
            this.Controls.Add(this.dtOfficeHoursStart);
            this.Controls.Add(this.dtOfficeHoursEnd);
            this.Controls.Add(this.chkOfficeHoursMon);
            this.Controls.Add(this.lblOfficeHoursEndTime);
            this.Controls.Add(this.chkOfficeHoursTue);
            this.Controls.Add(this.chkOfficeHoursThu);
            this.Controls.Add(this.chkOfficeHoursWed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditOfficeHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Office Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOfficeHoursFri;
        private System.Windows.Forms.DateTimePicker dtOfficeHoursEnd;
        private System.Windows.Forms.Label lblOfficeHoursEndTime;
        private System.Windows.Forms.CheckBox chkOfficeHoursThu;
        private System.Windows.Forms.CheckBox chkOfficeHoursWed;
        private System.Windows.Forms.CheckBox chkOfficeHoursTue;
        private System.Windows.Forms.CheckBox chkOfficeHoursMon;
        private System.Windows.Forms.DateTimePicker dtOfficeHoursStart;
        private System.Windows.Forms.Button btnOfficeHoursClose;
        private System.Windows.Forms.Button btnOfficeHoursSave;
        private System.Windows.Forms.Label lblRequiredOfficeHours1;
        private System.Windows.Forms.Label lblOfficeHoursStartTime;
        private System.Windows.Forms.Label lblOfficeHourDays;
        private System.Windows.Forms.Label lblRequiredOfficeHours3;
        private System.Windows.Forms.Label lblOfficeHoursText;
        private System.Windows.Forms.LinkLabel lnkPreviousOfficeHours;
        private System.Windows.Forms.LinkLabel lnkNextOfficeHours;
        private System.Windows.Forms.Button btnDeleteOfficeHours;
        private System.Windows.Forms.LinkLabel lnkAddOfficeHours;
        private System.Windows.Forms.Label lblRequiredOfficeHours2;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Timer timer1;




    }
}