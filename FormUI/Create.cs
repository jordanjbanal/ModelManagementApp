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
    public partial class Create : Form
    {

        public Create()
        {
            InitializeComponent();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameTextBox.Text, lastNameTextBox.Text, emailAddressTextBox.Text, Adult, Gender, EyeColor, SkinColor, HairColor, City, commentsRichTextBox.Text);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            commentsRichTextBox.Text = "";
      

            MessageBox.Show("Le model a bien ete ajoutea la liste");
            //TODO: Add a conditional statement checking if data has successfully been inserted into database

        }

        int Gender;
        private void femaleGenderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 1;
        }

        private void maleGenderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 0;
        }


        int Adult;
        private void yesAdultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Adult = 1;
        }

        private void noAdultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Adult = 0;
        }

        string City;
        //TODO: Add checking box displaying cities already exisiting in database & textbox to insert custom cities

        private void radioButtonCity1_CheckedChanged(object sender, EventArgs e)
        {
            City = "Nancy";
        }

        private void radioButtonCity2_CheckedChanged(object sender, EventArgs e)
        {
            City = "Metz";
        }

        private void radioButtonCity3_CheckedChanged(object sender, EventArgs e)
        {
            City = "Paris";
        }

        string EyeColor;
        private void blueEyeColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EyeColor = "Blue";
        }

        private void greenEyeColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EyeColor = "Green";
        }

        private void brownEyeColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EyeColor = "Brown";
        }

        private void blackEyeColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EyeColor = "Black";
        }

        string SkinColor;
        private void whiteSkinColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SkinColor = "White";
        }

        private void mixedSkinColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SkinColor = "Mixed";
        }

        private void blackSkinColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SkinColor = "Black";
        }

        string HairColor;
        //TODO: Add checking box displaying hair colors already exisiting in database & textbox to insert custom hair color

        private void blondHairColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HairColor = "Blond";
        }

        private void hazelHairColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HairColor = "Hazel";
        }

        private void brownHairColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HairColor = "Brown";
        }
    }
}
