using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{

    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            GrayOut();
        }

        private void GrayOut()
        {
            femaleFilterRadioButton.Enabled = false;
            maleFilterRadioButton.Enabled = false;
            yesAdultFilterRadioButton.Enabled = false;
            noAdultFilterRadioButton.Enabled = false;
            filterRadioButtonCity1.Enabled = false;
            filterRadioButtonCity2.Enabled = false;
            filterRadioButtonCity3.Enabled = false;
            blackEyeColorFilterRadioButton.Enabled = false;
            greenEyeColorFilterRadioButton.Enabled = false;
            blueEyeColorFilterRadioButton.Enabled = false;
            brownEyeColorFilterRadioButton.Enabled = false;
            blackSkinColorFilterRadioButton.Enabled = false;
            mixedSkinColorFilterRadioButton.Enabled = false;
            whiteSkinColorFilterRadioButton.Enabled = false;
            blondHairColorFilterRadioButton.Enabled = false;
            brownHairColorFilterRadioButton.Enabled = false;
            hazelHairColorFilterRadioButton.Enabled = false;
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            Form CreateModel = new Create();
            CreateModel.ShowDialog();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(searchTextBox.Text);

            UpdateBinding();

        }

        private void filterSearchButton_Click(object sender, EventArgs e)
        {
            string sqlString = "Select * from People where ";
            string genderString = "";
            string adultString = "";
            string cityString = "";
            string eyeColorString = "";
            string skinColorString = "";
            string hairColorString = "";

            List<string> addAndToString = new List<string>();

            if (femaleFilterRadioButton.Checked)
            {
                genderString += "(Gender = 1)";
            }
            if (maleFilterRadioButton.Checked)
            {
                genderString += "(Gender = 0)";
            }
            if(genderString != "")
            {
                addAndToString.Add(genderString);
            }

            if(yesAdultFilterRadioButton.Checked)
            {
                adultString += "(Adult = 1)";
            }
            if (noAdultFilterRadioButton.Checked)
            {
                adultString += "(Adult = 0)";
            }
            if (adultString != "")
            {
                addAndToString.Add(adultString);
            }

            if(filterRadioButtonCity1.Checked)
            {
                cityString += "(City = 'Nancy')";
            }

            if(filterRadioButtonCity2.Checked)
            {
                cityString += "(City = 'Metz')";
            }

            if(filterRadioButtonCity3.Checked)
            {
                cityString += "(City = 'Paris')";
            }

            if (cityString != "")
            {
                addAndToString.Add(cityString);
            }


            if (blackEyeColorFilterRadioButton.Checked)
            {
                eyeColorString += "(EyeColor = 'Black')";
            }

            if(blueEyeColorFilterRadioButton.Checked)
            {
                eyeColorString += "(EyeColor = 'Blue')";
            }
            
            if(brownEyeColorFilterRadioButton.Checked)
            {
                eyeColorString += "(EyeColor = 'Brown')";
            }
            
            if(greenEyeColorFilterRadioButton.Checked)
            {
                eyeColorString += "(EyeColor = 'Green')";
            }

            if (eyeColorString != "")
            {
                addAndToString.Add(eyeColorString);
            }

            if(blackSkinColorFilterRadioButton.Checked)
            {
                skinColorString += "(SkinColor = 'Black')";
            }

            if(mixedSkinColorFilterRadioButton.Checked)
            {
                skinColorString += "(SkinColor = 'Mixed')";
            }

            if(whiteSkinColorFilterRadioButton.Checked)
            {
                skinColorString += "(SkinColor = 'White')";
            }

            if (skinColorString != "")
            {
                addAndToString.Add(skinColorString);
            }

            if (blondHairColorFilterRadioButton.Checked)
            {
                hairColorString += "(HairColor = 'Blond')";
            }
            if(brownHairColorFilterRadioButton.Checked)
            {
                hairColorString += "(HairColor = 'Brown')";
            }
            if(hazelHairColorFilterRadioButton.Checked)
            {
                hairColorString += "(HairColor = 'Hazel')";
            }
            if (hairColorString != "")
            {
                addAndToString.Add(hairColorString);
            }

            string addedString = "";
            for (int i = 0; i < (addAndToString.Count); i++)
            {
                addedString += addAndToString[i];
                if (i != (addAndToString.Count - 1))
                {
                    addedString += " AND ";
                }
                if (i == (addAndToString.Count - 1))
                {
                    addedString += ";";
                }
            }


            sqlString += addedString;
            MessageBox.Show(sqlString);
            MessageBox.Show(addedString);

            DataAccess db = new DataAccess();

            people = db.GetPeopleByFilters(sqlString);

            UpdateBinding();
        }

        private void genderFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            femaleFilterRadioButton.Enabled = true;
            maleFilterRadioButton.Enabled = true;
            if(!genderFilterCheckBox.Checked)
            {
                femaleFilterRadioButton.Enabled = false;
                maleFilterRadioButton.Enabled = false;
            }
        }

        private void ageFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            noAdultFilterRadioButton.Enabled = true;
            yesAdultFilterRadioButton.Enabled = true;
            if (!ageFilterCheckBox.Checked)
            {
                noAdultFilterRadioButton.Enabled = false;
                yesAdultFilterRadioButton.Enabled = false;
            }
        }

        private void cityFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filterRadioButtonCity1.Enabled = true;
            filterRadioButtonCity2.Enabled = true;
            filterRadioButtonCity3.Enabled = true;
            if (!cityFilterCheckBox.Checked)
            {
                filterRadioButtonCity1.Enabled = false;
                filterRadioButtonCity2.Enabled = false;
                filterRadioButtonCity3.Enabled = false;
            }
        }

        private void eyeColorFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            blackEyeColorFilterRadioButton.Enabled = true;
            blueEyeColorFilterRadioButton.Enabled = true;
            brownEyeColorFilterRadioButton.Enabled = true;
            greenEyeColorFilterRadioButton.Enabled = true;
            if (!eyeColorFilterCheckBox.Checked)
            {
                blackEyeColorFilterRadioButton.Enabled = false;
                blueEyeColorFilterRadioButton.Enabled = false;
                brownEyeColorFilterRadioButton.Enabled = false;
                greenEyeColorFilterRadioButton.Enabled = false;
            }
        }

        private void skinColorFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            blackSkinColorFilterRadioButton.Enabled = true;
            mixedSkinColorFilterRadioButton.Enabled = true;
            whiteSkinColorFilterRadioButton.Enabled = true;
            if (!skinColorFilterCheckBox.Checked)
            {
                blackSkinColorFilterRadioButton.Enabled = false;
                mixedSkinColorFilterRadioButton.Enabled = false;
                whiteSkinColorFilterRadioButton.Enabled = false;
            }
        }

        private void hairColorFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            blondHairColorFilterRadioButton.Enabled = true;
            brownHairColorFilterRadioButton.Enabled = true;
            hazelHairColorFilterRadioButton.Enabled = true;
            if (!hairColorFilterCheckBox.Checked)
            {
                blondHairColorFilterRadioButton.Enabled = false;
                brownHairColorFilterRadioButton.Enabled = false;
                hazelHairColorFilterRadioButton.Enabled = false;
            }
        }

        //TODO: Create a ClearOut fuction for radio buttons whe grayed out
    }

}