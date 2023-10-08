//Author: Josh Werlein
//Purpose: Make an application that calculates calories
//Date: 10/04/2023

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CalorieCalculator
{
    public partial class CalorieCalculatorForm : Form
    {
        public CalorieCalculatorForm()
        {
            InitializeComponent();
        }

        //Create a selected User to reference which User is selected in the listbox
        private User selectedUserObject;

        //Create a BindingList of Users
        private BindingList<User> userList = new BindingList<User>();

        //Class level Object - User
        private CalorieCalculator.User userObject = new CalorieCalculator.User();

        //Declare class level variable
        int userLastNumber = 0;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            decimal decimalCheck;
            int intCheck;

            //Declare new User Object
            var userObject = new User();

            //Validate all input
            if (string.IsNullOrEmpty(this.nameTextBox.Text) || !this.nameTextBox.Text.All(char.IsLetter))
            {
                Msg("Name must be filled in with letters only.");
                this.nameTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(heightTextBox.Text, out decimalCheck) == false)
            {
                Msg("Height must be numeric.");
                this.heightTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(weightTextBox.Text, out decimalCheck) == false)
            {
                Msg("Weight must be numeric.");
                this.weightTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(ageTextBox.Text, out decimalCheck) == false)
            {
                Msg("Age must be numeric.");
                this.ageTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(genderComboBox.Text))
            {
                Msg("Gender must be selected.");
                this.genderComboBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(activityLevelComboBox.Text))
            {
                Msg("Activity must be selected.");
                this.activityLevelComboBox.Focus();
                return;
            }
            else if (decimal.TryParse(waistTextBox.Text, out decimalCheck) == false)
            {
                MessageBox.Show("Waist must be numeric");
                this.waistTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(wristTextBox.Text, out decimalCheck) == false && genderComboBox.SelectedIndex == 1)
            {
                MessageBox.Show("Wrist must be numeric");
                this.wristTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(hipTextBox.Text, out decimalCheck) == false && genderComboBox.SelectedIndex == 1)
            {
                MessageBox.Show("Hip must be numeric");
                this.hipTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(forearmTextBox.Text, out decimalCheck) == false && genderComboBox.SelectedIndex == 1)
            {
                MessageBox.Show("Forearm must be numeric");
                this.forearmTextBox.Focus();
                return;
            }
            else
            {
                //Assign User Information from Form
                if (userIDTextBox.Text == String.Empty)
                {
                    //If new record increment customerLastNumber
                    userLastNumber++;
                    userObject.UserID = userLastNumber;
                }
                else
                {
                    userObject.UserID = int.Parse(userIDTextBox.Text);
                }

                userObject.Name = nameTextBox.Text;
                userObject.Weight = decimal.Parse(weightTextBox.Text);
                userObject.Height = decimal.Parse(heightTextBox.Text);
                userObject.Waist = decimal.Parse(waistTextBox.Text);
                userObject.Age = decimal.Parse(ageTextBox.Text);
                userObject.Gender = genderComboBox.SelectedItem.ToString();
                userObject.ActivityLevel = activityLevelComboBox.SelectedItem.ToString();
                int activityIndex = activityLevelComboBox.SelectedIndex;

                //Create a List for Activity Levels
                var activityLevelsList = new List<decimal>();

                //Add multipliers to list by level
                activityLevelsList.Add(1.2m);
                activityLevelsList.Add(1.3m);
                activityLevelsList.Add(1.4m);
                activityLevelsList.Add(1.5m);
                activityLevelsList.Add(1.6m);
                activityLevelsList.Add(1.7m);
                activityLevelsList.Add(1.8m);

                if (userObject.Gender == "Male")
                {   //Calculates Activity Rate
                    userObject.BaseMetabolicRate = Math.Round(88.4m + 13.4m * (userObject.Weight * 0.453592m) + 4.8m * (userObject.Height * 2.54m) - (5.68m * userObject.Age), 0);
                    userObject.ActivityMetabolicRate = Math.Round(userObject.BaseMetabolicRate * activityLevelsList[activityIndex], 0);

                    //Calculates Body Fat
                    userObject.LeanBodyMass = ((userObject.Weight * 1.082m) + 94.42m) - (userObject.Waist * 4.15m);
                    userObject.BodyFatWeight = userObject.Weight - userObject.LeanBodyMass;
                    userObject.BodyFatPercentage = Math.Round((userObject.BodyFatWeight * 100) / userObject.Weight, 2);
                }
                else if (userObject.Gender == "Female")
                {
                    userObject.Wrist = decimal.Parse(wristTextBox.Text);
                    userObject.Hip = decimal.Parse(hipTextBox.Text);
                    userObject.Forearm = decimal.Parse(forearmTextBox.Text);

                    //Calculates Activity Rate for Females
                    userObject.BaseMetabolicRate = Math.Round(447.6m + 9.25m * (userObject.Weight * 0.453592m) + 3.1m * (userObject.Height) * 2.54m - (4.33m * userObject.Age), 0);
                    userObject.ActivityMetabolicRate = Math.Round(userObject.BaseMetabolicRate * activityLevelsList[activityIndex], 0);

                    //Body fat Calculation
                    userObject.LeanBodyMass = ((userObject.Weight * 0.732m) + 8.987m) + (userObject.Wrist / 3.140m) - (userObject.Waist * 0.157m) - (userObject.Hip * 0.249m) + (userObject.Forearm * 0.434m);
                    userObject.BodyFatWeight = userObject.Weight - userObject.LeanBodyMass;
                    userObject.BodyFatPercentage = Math.Round((userObject.BodyFatWeight * 100) / userObject.Weight, 2);
                }

                //Set object to selectedUserObject for binding list
                selectedUserObject = userObject;
                userList.Add(userObject);
                userListBox.SelectedItem = userObject;
                InsertUser();
                DisplayUser();
            }
        }

        private SqlConnection OpenDBConnection()
        {
            //Full path to bin/debug folder.
            string path = Application.StartupPath;
            int pathLength = path.Length;

            //Strip off the bin/debug folder to point  to the project folder
            path = path.Substring(0, pathLength - 25);

            //Create a connection string
            string connection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + path + "Fitness.mdf";

            //Create a connection Object to the database
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            //Open Database
            dbConnection.Open();

            return dbConnection;
        }

        private void ReloadUsers()
        {
            //Clear the Listbox
            userListBox.ClearSelected();

            //Open Database
            var connection = OpenDBConnection();

            //Create a Command Object
            var selectCommand = new SqlCommand("Select * from User_Tbl;", connection);

            //Execute a Command into a DataReader
            var userReader = selectCommand.ExecuteReader();
            if (userReader.HasRows)
            {
                while (userReader.Read())
                {
                    var storedUserObject = new CalorieCalculator.User((int)userReader["UserID"]);
                    storedUserObject.Name = userReader["Name"].ToString();
                    storedUserObject.Height = (decimal)(userReader["Height"]);
                    storedUserObject.Weight = (decimal)(userReader["Weight"]);
                    storedUserObject.Age = (decimal)(userReader["Age"]);
                    storedUserObject.Gender = userReader["Gender"].ToString();
                    storedUserObject.ActivityLevel = userReader["ActivityLevel"].ToString();
                    storedUserObject.Waist = (decimal)(userReader["Waist"]);
                    storedUserObject.Wrist = (decimal)(userReader["Wrist"]);
                    storedUserObject.Hip = (decimal)(userReader["Hip"]);
                    storedUserObject.Forearm = (decimal)(userReader["Forearm"]);
                    storedUserObject.ActivityMetabolicRate = (decimal)(userReader["ActivityMetabolicRate"]);
                    storedUserObject.BaseMetabolicRate = (decimal)(userReader["BaseMetabolicRate"]);
                    storedUserObject.BodyFatPercentage = (decimal)(userReader["BodyFatPercentage"]);

                    //Update UserID
                    if (storedUserObject.UserID > userLastNumber)
                    {
                        userLastNumber = storedUserObject.UserID;
                    }
                    Msg(userLastNumber.ToString());
                    userList.Add(storedUserObject);
                }
            }
            connection.Close();
            connection.Dispose();
        }

        private void InsertUser()
        {
            //Open Database
            var connection = OpenDBConnection();

            //Create SQL String
            string SQL = "Insert into User_Tbl (Name, Height, Weight, Age, Gender, ActivityLevel, Waist, Wrist, Hip, Forearm, ActivityMetabolicRate, BaseMetabolicRate, BodyFatPercentage) values (@Name, @Height, @Weight, @Age, @Gender, @ActivityLevel, @Waist, @Wrist, @Hip, @Forearm, @ActivityMetabolicRate, @BaseMetabolicRate, @BodyFatPercentage)";
            Msg(SQL.ToString());

            //Create Command
            var insertCommand = new SqlCommand(SQL, connection);

            //Populate Parameters of the Insert
            insertCommand.Parameters.AddWithValue("Name", userList.Last().Name);
            insertCommand.Parameters.AddWithValue("Height", userList.Last().Height);
            insertCommand.Parameters.AddWithValue("Weight", userList.Last().Weight);
            insertCommand.Parameters.AddWithValue("Age", userList.Last().Age);
            insertCommand.Parameters.AddWithValue("Gender", userList.Last().Gender);
            insertCommand.Parameters.AddWithValue("ActivityLevel", userList.Last().ActivityLevel);
            insertCommand.Parameters.AddWithValue("Waist", userList.Last().Waist);
            insertCommand.Parameters.AddWithValue("Wrist", userList.Last().Wrist);
            insertCommand.Parameters.AddWithValue("Hip", userList.Last().Hip);
            insertCommand.Parameters.AddWithValue("Forearm", userList.Last().Forearm);
            insertCommand.Parameters.AddWithValue("ActivityMetabolicRate", userList.Last().ActivityMetabolicRate);
            insertCommand.Parameters.AddWithValue("BaseMetabolicRate", userList.Last().BaseMetabolicRate);
            insertCommand.Parameters.AddWithValue("BodyFatPercentage", userList.Last().BodyFatPercentage);

            int intRowsAffected = insertCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                Msg(userList.Last().Name + " was inserted.");
            }
            else
            {
                Msg("The insert failed.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset ComboBoxes
            genderComboBox.SelectedIndex = -1;
            activityLevelComboBox.SelectedIndex = -1;

            //Clear Labels and Textboxes
            userIDTextBox.Text = string.Empty;
            nameTextBox.Text = String.Empty;
            heightTextBox.Text = String.Empty;
            weightTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
            waistTextBox.Text = String.Empty;
            wristTextBox.Text = String.Empty;
            hipTextBox.Text = String.Empty;
            forearmTextBox.Text = String.Empty;
            iDLabel.Text = String.Empty;
            userNameLabel.Text = string.Empty;
            userHeightLabel.Text = string.Empty;
            userWeightLabel.Text = string.Empty;
            userAgeLabel.Text = string.Empty;
            userGenderLabel.Text = string.Empty;
            userActivityLabel.Text = string.Empty;
            userBaseMetabolicRateLabel.Text = string.Empty;
            userActivityMetabolicRateLabel.Text = string.Empty;
            userBodyFatLabel.Text = string.Empty;
            userDescriptionLabel.Text = string.Empty;
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedUser();
        }

        private void ChangeSelectedUser()
        {
            if (userListBox.SelectedItem is object)
            {
                selectedUserObject = (User)userListBox.SelectedItem;
                DisplayUser();
            }
            else
            {
                selectedUserObject = null;
                DisplayUser();
            }
        }

        private void DisplayUser()
        {
            //Display the selected user
            userIDTextBox.Text = selectedUserObject.UserID.ToString();
            iDLabel.Text = selectedUserObject.UserID.ToString();
            userNameLabel.Text = selectedUserObject.Name;
            userHeightLabel.Text = selectedUserObject.Height.ToString() + " in.";
            userWeightLabel.Text = selectedUserObject.Weight.ToString() + " lbs.";
            userAgeLabel.Text = selectedUserObject.Age.ToString() + " years old";
            userGenderLabel.Text = selectedUserObject.Gender;
            userBaseMetabolicRateLabel.Text = selectedUserObject.BaseMetabolicRate.ToString() + " Calories";
            userActivityMetabolicRateLabel.Text = selectedUserObject.ActivityMetabolicRate.ToString() + " Calories";
            userActivityLabel.Text = selectedUserObject.ActivityLevel;
            userBodyFatLabel.Text = selectedUserObject.BodyFatPercentage.ToString() + "%";
            userDescriptionLabel.Text = selectedUserObject.User_Description();
        }

        private void CalorieCalculatorForm_Load(object sender, EventArgs e)
        {
            //Add Genders to comboBox on load
            this.genderComboBox.Items.Add("Male");
            this.genderComboBox.Items.Add("Female");

            //Selects first item to show in the comboBox on load
            this.genderComboBox.SelectedIndex = -1;
            this.activityLevelComboBox.SelectedIndex = -1;

            //Hides female groupBox on load
            femaleGroupBox.Visible = false;

            //Set User Binding List to Listbox
            userListBox.DataSource = userList;
            userListBox.DisplayMember = "Name";

            //Load Users from Database
            ReloadUsers();
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hides female groupBox until it is selected
            if (genderComboBox.SelectedIndex == 1)
            {
                femaleGroupBox.Visible = true;
            }
            else
            {
                femaleGroupBox.Visible = false;
            }
        }

        public void Msg(string msg)
        {
            //Method to handle all MessageBox's
            MessageBox.Show(msg, "User", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}