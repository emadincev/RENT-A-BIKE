
namespace RentABike
{
    partial class Rent
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNewTime = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.groupBoxWhoRents = new System.Windows.Forms.GroupBox();
            this.labelAdult = new System.Windows.Forms.Label();
            this.numericUpDownAdult = new System.Windows.Forms.NumericUpDown();
            this.labelChildren = new System.Windows.Forms.Label();
            this.numericUpDownChildren = new System.Windows.Forms.NumericUpDown();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.checkBoxBicycle = new System.Windows.Forms.CheckBox();
            this.checkBoxScooter = new System.Windows.Forms.CheckBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.groupBoxWhoRents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(42, 32);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(38, 268);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 20);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            // 
            // labelNewTime
            // 
            this.labelNewTime.AutoSize = true;
            this.labelNewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewTime.Location = new System.Drawing.Point(140, 268);
            this.labelNewTime.Name = "labelNewTime";
            this.labelNewTime.Size = new System.Drawing.Size(0, 20);
            this.labelNewTime.TabIndex = 2;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(38, 324);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(60, 20);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "Hours";
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "1 h",
            "2 h",
            "3 h",
            "4 h",
            "5 h"});
            this.comboBoxHours.Location = new System.Drawing.Point(134, 318);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(142, 28);
            this.comboBoxHours.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(38, 382);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(53, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(140, 382);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentPrice.TabIndex = 6;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrice.Location = new System.Drawing.Point(94, 436);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(116, 41);
            this.buttonPrice.TabIndex = 7;
            this.buttonPrice.Text = "Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // groupBoxWhoRents
            // 
            this.groupBoxWhoRents.Controls.Add(this.numericUpDownChildren);
            this.groupBoxWhoRents.Controls.Add(this.labelChildren);
            this.groupBoxWhoRents.Controls.Add(this.numericUpDownAdult);
            this.groupBoxWhoRents.Controls.Add(this.labelAdult);
            this.groupBoxWhoRents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWhoRents.Location = new System.Drawing.Point(376, 44);
            this.groupBoxWhoRents.Name = "groupBoxWhoRents";
            this.groupBoxWhoRents.Size = new System.Drawing.Size(262, 195);
            this.groupBoxWhoRents.TabIndex = 8;
            this.groupBoxWhoRents.TabStop = false;
            this.groupBoxWhoRents.Text = "Who Rents";
            // 
            // labelAdult
            // 
            this.labelAdult.AutoSize = true;
            this.labelAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdult.Location = new System.Drawing.Point(25, 46);
            this.labelAdult.Name = "labelAdult";
            this.labelAdult.Size = new System.Drawing.Size(52, 20);
            this.labelAdult.TabIndex = 0;
            this.labelAdult.Text = "Adult";
            // 
            // numericUpDownAdult
            // 
            this.numericUpDownAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAdult.Location = new System.Drawing.Point(134, 46);
            this.numericUpDownAdult.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAdult.Name = "numericUpDownAdult";
            this.numericUpDownAdult.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownAdult.TabIndex = 1;
            // 
            // labelChildren
            // 
            this.labelChildren.AutoSize = true;
            this.labelChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildren.Location = new System.Drawing.Point(29, 126);
            this.labelChildren.Name = "labelChildren";
            this.labelChildren.Size = new System.Drawing.Size(79, 20);
            this.labelChildren.TabIndex = 2;
            this.labelChildren.Text = "Children";
            // 
            // numericUpDownChildren
            // 
            this.numericUpDownChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownChildren.Location = new System.Drawing.Point(124, 123);
            this.numericUpDownChildren.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownChildren.Name = "numericUpDownChildren";
            this.numericUpDownChildren.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownChildren.TabIndex = 3;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.checkBoxScooter);
            this.groupBoxType.Controls.Add(this.checkBoxBicycle);
            this.groupBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxType.Location = new System.Drawing.Point(376, 283);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(262, 170);
            this.groupBoxType.TabIndex = 9;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // checkBoxBicycle
            // 
            this.checkBoxBicycle.AutoSize = true;
            this.checkBoxBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBicycle.Location = new System.Drawing.Point(60, 53);
            this.checkBoxBicycle.Name = "checkBoxBicycle";
            this.checkBoxBicycle.Size = new System.Drawing.Size(93, 24);
            this.checkBoxBicycle.TabIndex = 0;
            this.checkBoxBicycle.Text = "Bicycle";
            this.checkBoxBicycle.UseVisualStyleBackColor = true;
            // 
            // checkBoxScooter
            // 
            this.checkBoxScooter.AutoSize = true;
            this.checkBoxScooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxScooter.Location = new System.Drawing.Point(60, 99);
            this.checkBoxScooter.Name = "checkBoxScooter";
            this.checkBoxScooter.Size = new System.Drawing.Size(96, 24);
            this.checkBoxScooter.TabIndex = 1;
            this.checkBoxScooter.Text = "Scooter";
            this.checkBoxScooter.UseVisualStyleBackColor = true;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(741, 65);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(130, 45);
            this.buttonSignUp.TabIndex = 10;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(741, 138);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 45);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(741, 212);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(130, 45);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(695, 355);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(220, 45);
            this.buttonOrder.TabIndex = 13;
            this.buttonOrder.Text = "Check the order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 545);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxWhoRents);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelNewTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.groupBoxWhoRents.ResumeLayout(false);
            this.groupBoxWhoRents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNewTime;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.GroupBox groupBoxWhoRents;
        private System.Windows.Forms.NumericUpDown numericUpDownChildren;
        private System.Windows.Forms.Label labelChildren;
        private System.Windows.Forms.NumericUpDown numericUpDownAdult;
        private System.Windows.Forms.Label labelAdult;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.CheckBox checkBoxScooter;
        private System.Windows.Forms.CheckBox checkBoxBicycle;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonOrder;
    }
}