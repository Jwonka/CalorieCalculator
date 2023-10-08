namespace CalorieCalculator
{
    partial class CalorieCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            resetButton = new Button();
            bodyFatLabel = new Label();
            activityLabel2 = new Label();
            nameLabel2 = new Label();
            heightLabel2 = new Label();
            rmrLabel = new Label();
            genderLabel2 = new Label();
            ageLabel2 = new Label();
            weightLabel2 = new Label();
            userListBox = new ListBox();
            userLabel = new Label();
            forearmLabel = new Label();
            hipLabel = new Label();
            wristLabel = new Label();
            forearmTextBox = new TextBox();
            hipTextBox = new TextBox();
            wristTextBox = new TextBox();
            femaleGroupBox = new GroupBox();
            userGroupBox = new GroupBox();
            label2 = new Label();
            iDLabel = new Label();
            userDescriptionLabel = new Label();
            activityLabel3 = new Label();
            userActivityLabel = new Label();
            userBodyFatLabel = new Label();
            userActivityMetabolicRateLabel = new Label();
            userBaseMetabolicRateLabel = new Label();
            userGenderLabel = new Label();
            userAgeLabel = new Label();
            userWeightLabel = new Label();
            userHeightLabel = new Label();
            userNameLabel = new Label();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            genderComboBox = new ComboBox();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            genderLabel = new Label();
            heightTextBox = new TextBox();
            heightLabel = new Label();
            activityLevelComboBox = new ComboBox();
            activityLevelLabel = new Label();
            nameLabel = new Label();
            waistTextBox = new TextBox();
            nameTextBox = new TextBox();
            waistLabel = new Label();
            userIDTextBox = new TextBox();
            controlGroupBox = new GroupBox();
            userIDLabel = new Label();
            femaleGroupBox.SuspendLayout();
            userGroupBox.SuspendLayout();
            controlGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.SteelBlue;
            calculateButton.Location = new Point(8, 268);
            calculateButton.Margin = new Padding(2, 2, 2, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(204, 34);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate Fitness";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += CalculateButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.SteelBlue;
            resetButton.Location = new Point(216, 268);
            resetButton.Margin = new Padding(2, 2, 2, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(160, 34);
            resetButton.TabIndex = 6;
            resetButton.Text = "Clear";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ClearButton_Click;
            // 
            // bodyFatLabel
            // 
            bodyFatLabel.Location = new Point(30, 221);
            bodyFatLabel.Margin = new Padding(2, 0, 2, 0);
            bodyFatLabel.Name = "bodyFatLabel";
            bodyFatLabel.Size = new Size(74, 19);
            bodyFatLabel.TabIndex = 16;
            bodyFatLabel.Text = "Body Fat:";
            bodyFatLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // activityLabel2
            // 
            activityLabel2.Location = new Point(22, 165);
            activityLabel2.Margin = new Padding(2, 0, 2, 0);
            activityLabel2.Name = "activityLabel2";
            activityLabel2.Size = new Size(80, 19);
            activityLabel2.TabIndex = 13;
            activityLabel2.Text = "Activity MR:";
            activityLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameLabel2
            // 
            nameLabel2.Location = new Point(49, 16);
            nameLabel2.Margin = new Padding(2, 0, 2, 0);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new Size(53, 16);
            nameLabel2.TabIndex = 11;
            nameLabel2.Text = "Name:";
            nameLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightLabel2
            // 
            heightLabel2.Location = new Point(46, 37);
            heightLabel2.Margin = new Padding(2, 0, 2, 0);
            heightLabel2.Name = "heightLabel2";
            heightLabel2.Size = new Size(62, 19);
            heightLabel2.TabIndex = 10;
            heightLabel2.Text = "Height:";
            heightLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rmrLabel
            // 
            rmrLabel.Location = new Point(62, 136);
            rmrLabel.Margin = new Padding(2, 0, 2, 0);
            rmrLabel.Name = "rmrLabel";
            rmrLabel.Size = new Size(41, 20);
            rmrLabel.TabIndex = 8;
            rmrLabel.Text = "BMR:";
            rmrLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genderLabel2
            // 
            genderLabel2.Location = new Point(49, 114);
            genderLabel2.Margin = new Padding(2, 0, 2, 0);
            genderLabel2.Name = "genderLabel2";
            genderLabel2.Size = new Size(53, 20);
            genderLabel2.TabIndex = 9;
            genderLabel2.Text = "Gender:";
            genderLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ageLabel2
            // 
            ageLabel2.Location = new Point(61, 89);
            ageLabel2.Margin = new Padding(2, 0, 2, 0);
            ageLabel2.Name = "ageLabel2";
            ageLabel2.Size = new Size(41, 19);
            ageLabel2.TabIndex = 12;
            ageLabel2.Text = "Age:";
            ageLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weightLabel2
            // 
            weightLabel2.Location = new Point(46, 62);
            weightLabel2.Margin = new Padding(2, 0, 2, 0);
            weightLabel2.Name = "weightLabel2";
            weightLabel2.Size = new Size(60, 19);
            weightLabel2.TabIndex = 11;
            weightLabel2.Text = "Weight:";
            weightLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userListBox
            // 
            userListBox.BackColor = Color.DodgerBlue;
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 15;
            userListBox.Location = new Point(390, 336);
            userListBox.Margin = new Padding(2, 2, 2, 2);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(404, 109);
            userListBox.TabIndex = 15;
            userListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
            // 
            // userLabel
            // 
            userLabel.Location = new Point(390, 318);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(54, 16);
            userLabel.TabIndex = 16;
            userLabel.Text = "Users:";
            userLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // forearmLabel
            // 
            forearmLabel.Location = new Point(3, 97);
            forearmLabel.Margin = new Padding(2, 0, 2, 0);
            forearmLabel.Name = "forearmLabel";
            forearmLabel.Size = new Size(101, 19);
            forearmLabel.TabIndex = 19;
            forearmLabel.Text = "Forearm (inches):";
            forearmLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // hipLabel
            // 
            hipLabel.Location = new Point(19, 61);
            hipLabel.Margin = new Padding(2, 0, 2, 0);
            hipLabel.Name = "hipLabel";
            hipLabel.Size = new Size(85, 19);
            hipLabel.TabIndex = 18;
            hipLabel.Text = "Hip (inches):";
            hipLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wristLabel
            // 
            wristLabel.Location = new Point(19, 26);
            wristLabel.Margin = new Padding(2, 0, 2, 0);
            wristLabel.Name = "wristLabel";
            wristLabel.Size = new Size(85, 19);
            wristLabel.TabIndex = 17;
            wristLabel.Text = "Wrist (inches):";
            wristLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // forearmTextBox
            // 
            forearmTextBox.BackColor = Color.DeepSkyBlue;
            forearmTextBox.BorderStyle = BorderStyle.FixedSingle;
            forearmTextBox.Location = new Point(118, 97);
            forearmTextBox.Margin = new Padding(2, 2, 2, 2);
            forearmTextBox.Name = "forearmTextBox";
            forearmTextBox.Size = new Size(220, 23);
            forearmTextBox.TabIndex = 16;
            // 
            // hipTextBox
            // 
            hipTextBox.BackColor = Color.DeepSkyBlue;
            hipTextBox.BorderStyle = BorderStyle.FixedSingle;
            hipTextBox.Location = new Point(118, 61);
            hipTextBox.Margin = new Padding(2, 2, 2, 2);
            hipTextBox.Name = "hipTextBox";
            hipTextBox.Size = new Size(220, 23);
            hipTextBox.TabIndex = 15;
            // 
            // wristTextBox
            // 
            wristTextBox.BackColor = Color.DeepSkyBlue;
            wristTextBox.BorderStyle = BorderStyle.FixedSingle;
            wristTextBox.Location = new Point(118, 26);
            wristTextBox.Margin = new Padding(2, 2, 2, 2);
            wristTextBox.Name = "wristTextBox";
            wristTextBox.Size = new Size(220, 23);
            wristTextBox.TabIndex = 14;
            // 
            // femaleGroupBox
            // 
            femaleGroupBox.BackColor = Color.DodgerBlue;
            femaleGroupBox.Controls.Add(wristLabel);
            femaleGroupBox.Controls.Add(hipLabel);
            femaleGroupBox.Controls.Add(forearmLabel);
            femaleGroupBox.Controls.Add(wristTextBox);
            femaleGroupBox.Controls.Add(hipTextBox);
            femaleGroupBox.Controls.Add(forearmTextBox);
            femaleGroupBox.Location = new Point(8, 306);
            femaleGroupBox.Margin = new Padding(2, 2, 2, 2);
            femaleGroupBox.Name = "femaleGroupBox";
            femaleGroupBox.Padding = new Padding(2, 2, 2, 2);
            femaleGroupBox.Size = new Size(368, 136);
            femaleGroupBox.TabIndex = 18;
            femaleGroupBox.TabStop = false;
            femaleGroupBox.Text = "Female - Body Fat Calculation";
            // 
            // userGroupBox
            // 
            userGroupBox.BackColor = Color.DodgerBlue;
            userGroupBox.Controls.Add(label2);
            userGroupBox.Controls.Add(iDLabel);
            userGroupBox.Controls.Add(userDescriptionLabel);
            userGroupBox.Controls.Add(activityLabel3);
            userGroupBox.Controls.Add(userActivityLabel);
            userGroupBox.Controls.Add(userBodyFatLabel);
            userGroupBox.Controls.Add(userActivityMetabolicRateLabel);
            userGroupBox.Controls.Add(userBaseMetabolicRateLabel);
            userGroupBox.Controls.Add(userGenderLabel);
            userGroupBox.Controls.Add(userAgeLabel);
            userGroupBox.Controls.Add(userWeightLabel);
            userGroupBox.Controls.Add(userHeightLabel);
            userGroupBox.Controls.Add(userNameLabel);
            userGroupBox.Controls.Add(bodyFatLabel);
            userGroupBox.Controls.Add(nameLabel2);
            userGroupBox.Controls.Add(activityLabel2);
            userGroupBox.Controls.Add(heightLabel2);
            userGroupBox.Controls.Add(rmrLabel);
            userGroupBox.Controls.Add(weightLabel2);
            userGroupBox.Controls.Add(genderLabel2);
            userGroupBox.Controls.Add(ageLabel2);
            userGroupBox.Location = new Point(390, 7);
            userGroupBox.Margin = new Padding(2, 2, 2, 2);
            userGroupBox.Name = "userGroupBox";
            userGroupBox.Padding = new Padding(2, 2, 2, 2);
            userGroupBox.Size = new Size(402, 309);
            userGroupBox.TabIndex = 20;
            userGroupBox.TabStop = false;
            userGroupBox.Text = "Current User Report";
            // 
            // label2
            // 
            label2.Location = new Point(244, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 29;
            label2.Text = "User ID:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iDLabel
            // 
            iDLabel.Location = new Point(309, 16);
            iDLabel.Margin = new Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new Size(71, 16);
            iDLabel.TabIndex = 28;
            iDLabel.Text = "*";
            iDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userDescriptionLabel
            // 
            userDescriptionLabel.Location = new Point(4, 241);
            userDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            userDescriptionLabel.Name = "userDescriptionLabel";
            userDescriptionLabel.Size = new Size(394, 67);
            userDescriptionLabel.TabIndex = 27;
            userDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // activityLabel3
            // 
            activityLabel3.Location = new Point(28, 195);
            activityLabel3.Margin = new Padding(2, 0, 2, 0);
            activityLabel3.Name = "activityLabel3";
            activityLabel3.Size = new Size(74, 19);
            activityLabel3.TabIndex = 26;
            activityLabel3.Text = "Activity:";
            activityLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userActivityLabel
            // 
            userActivityLabel.Location = new Point(108, 195);
            userActivityLabel.Margin = new Padding(2, 0, 2, 0);
            userActivityLabel.Name = "userActivityLabel";
            userActivityLabel.Size = new Size(290, 19);
            userActivityLabel.TabIndex = 25;
            userActivityLabel.Text = "*";
            userActivityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userBodyFatLabel
            // 
            userBodyFatLabel.Location = new Point(108, 224);
            userBodyFatLabel.Margin = new Padding(2, 0, 2, 0);
            userBodyFatLabel.Name = "userBodyFatLabel";
            userBodyFatLabel.Size = new Size(290, 16);
            userBodyFatLabel.TabIndex = 24;
            userBodyFatLabel.Text = "*";
            userBodyFatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userActivityMetabolicRateLabel
            // 
            userActivityMetabolicRateLabel.Location = new Point(108, 168);
            userActivityMetabolicRateLabel.Margin = new Padding(2, 0, 2, 0);
            userActivityMetabolicRateLabel.Name = "userActivityMetabolicRateLabel";
            userActivityMetabolicRateLabel.Size = new Size(290, 16);
            userActivityMetabolicRateLabel.TabIndex = 23;
            userActivityMetabolicRateLabel.Text = "*";
            userActivityMetabolicRateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userBaseMetabolicRateLabel
            // 
            userBaseMetabolicRateLabel.Location = new Point(107, 140);
            userBaseMetabolicRateLabel.Margin = new Padding(2, 0, 2, 0);
            userBaseMetabolicRateLabel.Name = "userBaseMetabolicRateLabel";
            userBaseMetabolicRateLabel.Size = new Size(291, 16);
            userBaseMetabolicRateLabel.TabIndex = 22;
            userBaseMetabolicRateLabel.Text = "*";
            userBaseMetabolicRateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userGenderLabel
            // 
            userGenderLabel.Location = new Point(108, 118);
            userGenderLabel.Margin = new Padding(2, 0, 2, 0);
            userGenderLabel.Name = "userGenderLabel";
            userGenderLabel.Size = new Size(290, 16);
            userGenderLabel.TabIndex = 21;
            userGenderLabel.Text = "*";
            userGenderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userAgeLabel
            // 
            userAgeLabel.Location = new Point(107, 92);
            userAgeLabel.Margin = new Padding(2, 0, 2, 0);
            userAgeLabel.Name = "userAgeLabel";
            userAgeLabel.Size = new Size(291, 16);
            userAgeLabel.TabIndex = 20;
            userAgeLabel.Text = "*";
            userAgeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userWeightLabel
            // 
            userWeightLabel.Location = new Point(108, 65);
            userWeightLabel.Margin = new Padding(2, 0, 2, 0);
            userWeightLabel.Name = "userWeightLabel";
            userWeightLabel.Size = new Size(290, 16);
            userWeightLabel.TabIndex = 19;
            userWeightLabel.Text = "*";
            userWeightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userHeightLabel
            // 
            userHeightLabel.Location = new Point(108, 40);
            userHeightLabel.Margin = new Padding(2, 0, 2, 0);
            userHeightLabel.Name = "userHeightLabel";
            userHeightLabel.Size = new Size(290, 16);
            userHeightLabel.TabIndex = 18;
            userHeightLabel.Text = "*";
            userHeightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userNameLabel
            // 
            userNameLabel.Location = new Point(106, 16);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(71, 16);
            userNameLabel.TabIndex = 17;
            userNameLabel.Text = "*";
            userNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            weightLabel.Location = new Point(19, 109);
            weightLabel.Margin = new Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(85, 19);
            weightLabel.TabIndex = 11;
            weightLabel.Text = "Weight (lbs.):";
            weightLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // weightTextBox
            // 
            weightTextBox.BackColor = Color.DeepSkyBlue;
            weightTextBox.BorderStyle = BorderStyle.FixedSingle;
            weightTextBox.Location = new Point(118, 109);
            weightTextBox.Margin = new Padding(2, 2, 2, 2);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(220, 23);
            weightTextBox.TabIndex = 2;
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.DeepSkyBlue;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FlatStyle = FlatStyle.Flat;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(118, 164);
            genderComboBox.Margin = new Padding(2, 2, 2, 2);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(220, 23);
            genderComboBox.TabIndex = 4;
            genderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // ageLabel
            // 
            ageLabel.Location = new Point(49, 136);
            ageLabel.Margin = new Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(53, 19);
            ageLabel.TabIndex = 12;
            ageLabel.Text = "Age:";
            ageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = Color.DeepSkyBlue;
            ageTextBox.BorderStyle = BorderStyle.FixedSingle;
            ageTextBox.Location = new Point(118, 136);
            ageTextBox.Margin = new Padding(2, 2, 2, 2);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(220, 23);
            ageTextBox.TabIndex = 3;
            // 
            // genderLabel
            // 
            genderLabel.Location = new Point(49, 164);
            genderLabel.Margin = new Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(53, 20);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender:";
            genderLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // heightTextBox
            // 
            heightTextBox.BackColor = Color.DeepSkyBlue;
            heightTextBox.BorderStyle = BorderStyle.FixedSingle;
            heightTextBox.Location = new Point(118, 80);
            heightTextBox.Margin = new Padding(2, 2, 2, 2);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(220, 23);
            heightTextBox.TabIndex = 1;
            // 
            // heightLabel
            // 
            heightLabel.Location = new Point(4, 79);
            heightLabel.Margin = new Padding(2, 0, 2, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(99, 19);
            heightLabel.TabIndex = 10;
            heightLabel.Text = "Height (inches):";
            heightLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // activityLevelComboBox
            // 
            activityLevelComboBox.BackColor = Color.DeepSkyBlue;
            activityLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityLevelComboBox.FlatStyle = FlatStyle.Flat;
            activityLevelComboBox.FormattingEnabled = true;
            activityLevelComboBox.Items.AddRange(new object[] { "Sitting, No Activity", "Seated Work, no exercise", "Seated Work, light exercise", "Moderately physical work, no exercise", "Moderately physical work, light exercise", "Moderately physical work, heavy exercise", "Heavy work or Heavy exercise" });
            activityLevelComboBox.Location = new Point(118, 194);
            activityLevelComboBox.Margin = new Padding(2, 2, 2, 2);
            activityLevelComboBox.Name = "activityLevelComboBox";
            activityLevelComboBox.Size = new Size(220, 23);
            activityLevelComboBox.TabIndex = 5;
            // 
            // activityLevelLabel
            // 
            activityLevelLabel.Location = new Point(19, 194);
            activityLevelLabel.Margin = new Padding(2, 0, 2, 0);
            activityLevelLabel.Name = "activityLevelLabel";
            activityLevelLabel.Size = new Size(85, 20);
            activityLevelLabel.TabIndex = 8;
            activityLevelLabel.Text = "Activity Level:";
            activityLevelLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(48, 53);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(54, 16);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // waistTextBox
            // 
            waistTextBox.BackColor = Color.DeepSkyBlue;
            waistTextBox.BorderStyle = BorderStyle.FixedSingle;
            waistTextBox.Location = new Point(118, 221);
            waistTextBox.Margin = new Padding(2, 2, 2, 2);
            waistTextBox.Name = "waistTextBox";
            waistTextBox.Size = new Size(220, 23);
            waistTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.DeepSkyBlue;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(118, 53);
            nameTextBox.Margin = new Padding(2, 2, 2, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(220, 23);
            nameTextBox.TabIndex = 0;
            // 
            // waistLabel
            // 
            waistLabel.Location = new Point(5, 221);
            waistLabel.Margin = new Padding(2, 0, 2, 0);
            waistLabel.Name = "waistLabel";
            waistLabel.Size = new Size(99, 19);
            waistLabel.TabIndex = 13;
            waistLabel.Text = "Waist (inches):";
            waistLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userIDTextBox
            // 
            userIDTextBox.BackColor = Color.DeepSkyBlue;
            userIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            userIDTextBox.Enabled = false;
            userIDTextBox.Location = new Point(118, 25);
            userIDTextBox.Margin = new Padding(2, 2, 2, 2);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(220, 23);
            userIDTextBox.TabIndex = 14;
            // 
            // controlGroupBox
            // 
            controlGroupBox.BackColor = Color.DodgerBlue;
            controlGroupBox.Controls.Add(userIDLabel);
            controlGroupBox.Controls.Add(userIDTextBox);
            controlGroupBox.Controls.Add(waistLabel);
            controlGroupBox.Controls.Add(nameTextBox);
            controlGroupBox.Controls.Add(waistTextBox);
            controlGroupBox.Controls.Add(nameLabel);
            controlGroupBox.Controls.Add(activityLevelLabel);
            controlGroupBox.Controls.Add(activityLevelComboBox);
            controlGroupBox.Controls.Add(heightLabel);
            controlGroupBox.Controls.Add(heightTextBox);
            controlGroupBox.Controls.Add(genderLabel);
            controlGroupBox.Controls.Add(ageTextBox);
            controlGroupBox.Controls.Add(ageLabel);
            controlGroupBox.Controls.Add(genderComboBox);
            controlGroupBox.Controls.Add(weightTextBox);
            controlGroupBox.Controls.Add(weightLabel);
            controlGroupBox.Location = new Point(8, 7);
            controlGroupBox.Margin = new Padding(2, 2, 2, 2);
            controlGroupBox.Name = "controlGroupBox";
            controlGroupBox.Padding = new Padding(2, 2, 2, 2);
            controlGroupBox.Size = new Size(368, 257);
            controlGroupBox.TabIndex = 17;
            controlGroupBox.TabStop = false;
            controlGroupBox.Text = "General Information";
            // 
            // userIDLabel
            // 
            userIDLabel.Location = new Point(48, 25);
            userIDLabel.Margin = new Padding(2, 0, 2, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(54, 16);
            userIDLabel.TabIndex = 15;
            userIDLabel.Text = "User ID:";
            userIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CalorieCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(801, 449);
            Controls.Add(userGroupBox);
            Controls.Add(femaleGroupBox);
            Controls.Add(controlGroupBox);
            Controls.Add(userLabel);
            Controls.Add(userListBox);
            Controls.Add(resetButton);
            Controls.Add(calculateButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CalorieCalculatorForm";
            Text = "Calorie Calculator";
            Load += CalorieCalculatorForm_Load;
            femaleGroupBox.ResumeLayout(false);
            femaleGroupBox.PerformLayout();
            userGroupBox.ResumeLayout(false);
            controlGroupBox.ResumeLayout(false);
            controlGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button calculateButton;
        private Button resetButton;
        private Label activityLabel2;
        private Label nameLabel2;
        private Label heightLabel2;
        private Label rmrLabel;
        private Label genderLabel2;
        private Label ageLabel2;
        private Label weightLabel2;
        private Label bodyFatLabel;
        private ListBox userListBox;
        private Label userLabel;
        private Label forearmLabel;
        private Label hipLabel;
        private Label wristLabel;
        private TextBox forearmTextBox;
        private TextBox hipTextBox;
        private TextBox wristTextBox;
        private GroupBox femaleGroupBox;
        private GroupBox userGroupBox;
        private Label userHeightLabel;
        private Label userNameLabel;
        private Label userWeightLabel;
        private Label userGenderLabel;
        private Label userAgeLabel;
        private Label userBodyFatLabel;
        private Label userActivityMetabolicRateLabel;
        private Label userBaseMetabolicRateLabel;
        private Label activityLabel3;
        private Label userActivityLabel;
        private Label userDescriptionLabel;
        private Label weightLabel;
        private TextBox weightTextBox;
        private ComboBox genderComboBox;
        private Label ageLabel;
        private TextBox ageTextBox;
        private Label genderLabel;
        private TextBox heightTextBox;
        private Label heightLabel;
        private ComboBox activityLevelComboBox;
        private Label activityLevelLabel;
        private Label nameLabel;
        private TextBox waistTextBox;
        private TextBox nameTextBox;
        private Label waistLabel;
        private TextBox userIDTextBox;
        private GroupBox controlGroupBox;
        private Label userIDLabel;
        private Label label2;
        private Label iDLabel;
    }
}