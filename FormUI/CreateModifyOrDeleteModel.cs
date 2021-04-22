using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class CreateModifyOrDeleteModel : Form
    {
        Person model = new Person();

        public CreateModifyOrDeleteModel()
        {
            InitializeComponent();
            ModifyBtn.Enabled = false;
            deleteBtn.Enabled = false;
            label1.Visible = false;
        }

        public string Capitalize(string word)
        {
                return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();

        }

        private void ModifyOrDeleteModel_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        void Clear()
        {
            //Empty all textboxes and uncheck all checkboxes
            firstNameTextBox.Text = lastNameTextBox.Text = emailAddressTextBox.Text = commentsRichTextBox.Text = instaHandleTextBox.Text = "";
            maleGenderRadioButton.Checked = femaleGenderRadioButton.Checked = yesAdultRadioButton.Checked = noAdultRadioButton.Checked = radioButtonCity1.Checked = radioButtonCity2.Checked = radioButtonCity3.Checked = blondHairColorRadioButton.Checked = brownHairColorRadioButton.Checked = hazelHairColorRadioButton.Checked = blackSkinColorRadioButton.Checked = mixedSkinColorRadioButton.Checked = whiteSkinColorRadioButton.Checked = blackEyeColorRadioButton.Checked = blueEyeColorRadioButton.Checked = greenEyeColorRadioButton.Checked = brownEyeColorRadioButton.Checked = false;
            model.id = 0;
            label1.Text = ".";
            ModifyBtn.Enabled = false;
            deleteBtn.Enabled = false;
            addBtn.Enabled = true;
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string FirstName = "";
            string LastName = "";
            string EmailAddress = "";
            string InstaHandle = "";
            string errorMessage = "Les champs/coches suivant(e)s doivent être renseigné(e)s:\n";
            InstaHandle = instaHandleTextBox.Text;
            FirstName = firstNameTextBox.Text;
            LastName = lastNameTextBox.Text;
            EmailAddress = emailAddressTextBox.Text;


            //Add an '@' before the instagram handle if not provided
            if (InstaHandle != "")
            {
                if (InstaHandle.Substring(0, 1) != "@")
                {
                    InstaHandle = $"@{InstaHandle}";
                }
            }

            //First name is a required field, if not provided it will be shown in an error message
            if (FirstName == "")
            {
                errorMessage += "_Prénom\n";
            }
            //If first name is provided, it will be capitalized if it's not
            else
            {
                FirstName = Capitalize(firstNameTextBox.Text);
            }

            //Last name is a required field, if not provided it will be shown in an error message
            if (LastName == "")
            {
                errorMessage += "_Nom de famille\n";
            }
            //If first name is provided, it will be capitalized if it's not
            else
            {
                LastName = Capitalize(lastNameTextBox.Text);
            }

            if (yesAdultRadioButton.Checked == false && noAdultRadioButton.Checked== false)
            {
                errorMessage += "_Majeur ou non\n";
            }

            /*
             //Those are optional inputs, no need for error message prompt
            if (EmailAddress == "")
            {
                errorMessage += "_Adresse e-mail\n";
            }

            if (maleGenderRadioButton.Checked == false && femaleGenderRadioButton.Checked == false)
            {
                errorMessage += "_Genre\n";
            }

            if(radioButtonCity1.Checked == false && radioButtonCity2.Checked == false && radioButtonCity3.Checked == false)
            {
                errorMessage += "_Ville\n";
            }

            if(blackEyeColorRadioButton.Checked == false && blueEyeColorRadioButton.Checked == false && brownEyeColorRadioButton.Checked == false && greenEyeColorRadioButton.Checked == false)
            {
                errorMessage += "_Couleur des yeux\n";
            }

            if (blackSkinColorRadioButton.Checked == false && mixedSkinColorRadioButton.Checked == false && whiteSkinColorRadioButton.Checked == false)
            {
                errorMessage += "_Couleur de peau\n";
            }

            if (blondHairColorRadioButton.Checked == false && brownHairColorRadioButton.Checked == false && hazelHairColorRadioButton.Checked == false)
            {
                errorMessage += "_Couleur des cheveux\n";
            }

            */

            //If 
            if (!(errorMessage == "Les champs/coches suivant(e)s doivent être renseigné(e)s:\n"))
            {
                MessageBox.Show(errorMessage);
            }

            if (!(firstNameTextBox.Text == "") && !(lastNameTextBox.Text == "")  && (yesAdultRadioButton.Checked == true || noAdultRadioButton.Checked == true))
            {
                db.InsertPerson(InstaHandle, FirstName, LastName, EmailAddress, Adult, Gender, EyeColor, SkinColor, HairColor, City, commentsRichTextBox.Text);
                    MessageBox.Show($"{FirstName} a bien été ajouté! :)");
                //}


                LoadAllRecords();
                Clear();
            }
        }

        int Gender;
        private void femaleGenderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 2;
        }
        private void maleGenderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 1;
        }

        int Adult;

        private void yesAdultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Adult = 2;
        }

        private void noAdultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Adult = 1;
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


        void LoadAllRecords()
        {
            DataAccess db = new DataAccess();
            dataGridView1.DataSource = db.ViewPeople();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyBtn.Enabled = true;
            deleteBtn.Enabled = true;
            addBtn.Enabled = false;
            //Taking the ID of the selected row
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!(dataGridView1.Rows[e.RowIndex].Cells[1].Value is null))
            {
                instaHandleTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            firstNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lastNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailAddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int Adult = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            int Gender = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string EyeColor = (string)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
            string SkinColor = (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
            string HairColor = (string)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
            string City = (string)dataGridView1.Rows[e.RowIndex].Cells[10].Value;
            commentsRichTextBox.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[11].Value;

            if (Gender == 1)
            {
                maleGenderRadioButton.Checked = true;
            }
            else if(Gender == 2)
            {
                femaleGenderRadioButton.Checked = true;
            }

            if(Adult == 1)
            {
                noAdultRadioButton.Checked = true;
            }
            else if(Adult == 2)
            {
                yesAdultRadioButton.Checked = true;
            }

            if(City == "Nancy")
            {
                radioButtonCity1.Checked = true;
            }
            else if(City == "Metz")
            {
                radioButtonCity2.Checked = true;
            }
            else if(City == "Paris")
            {
                radioButtonCity3.Checked = true;
            }

            if(EyeColor == "Blue")
            {
                blueEyeColorRadioButton.Checked = true;
            }
            else if(EyeColor == "Green")
            {
                greenEyeColorRadioButton.Checked = true;
            }
            else if(EyeColor == "Brown")
            {
                brownEyeColorRadioButton.Checked = true;
            }
            else if(EyeColor == "Black")
            {
                blackEyeColorRadioButton.Checked = true;
            }

            if(SkinColor == "White")
            {
                whiteSkinColorRadioButton.Checked = true;
            }
            else if(SkinColor == "Mixed")
            {
                mixedSkinColorRadioButton.Checked = true;
            }
            else if(SkinColor == "Black")
            {
                blackSkinColorRadioButton.Checked = true;
            }


            if(HairColor == "Blond")
            {
                blondHairColorRadioButton.Checked = true;
            }
            else if(HairColor == "Hazel")
            {
                hazelHairColorRadioButton.Checked = true;
            }
            else if(HairColor == "Brown")
            {
                brownHairColorRadioButton.Checked = true;
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            if(!(label1.Text == "."))
            {
                int Id = Convert.ToInt32(label1.Text);
                string FirstName = "";
                string LastName = "";
                string EmailAddress = "";
                string InstaHandle;
                InstaHandle = instaHandleTextBox.Text;
                FirstName = firstNameTextBox.Text;
                LastName = lastNameTextBox.Text;
                EmailAddress = emailAddressTextBox.Text;
                string errorMessage = "";
                //if (!(FirstName == "") && !(LastName == "") && !(Gender == 0) && !(Adult == 0) && !(City is null) && !(EyeColor is null) && !(SkinColor is null) && !(HairColor is null))
                //{
                    db.UpdatePeople(Id, InstaHandle, FirstName, LastName, EmailAddress, Adult, Gender, EyeColor, SkinColor, HairColor, City, commentsRichTextBox.Text);
                    MessageBox.Show("Le model va etre modifie!");
                //}

                if (!(errorMessage == ""))
                {
                    MessageBox.Show(errorMessage);
                }
                LoadAllRecords();
                Clear();
                dataGridView1.DataSource = db.ViewPeople();
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un model pour le modifier.");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!(label1.Text == "."))
            {
                string InstaHandle = "";
                string FirstName = "";
                string LastName = "";
                string EmailAddress = "";
                //if ((!(FirstName == "") && !(LastName == "") && !(EmailAddress == "") && !(Gender == 0) && !(Adult == 0) && !(City is null) && !(EyeColor is null) && !(SkinColor is null) && !(HairColor is null)))
                //{
                    DataAccess db = new DataAccess();
                    int Id = Convert.ToInt32(label1.Text);
                    InstaHandle = instaHandleTextBox.Text;
                    FirstName = firstNameTextBox.Text;
                    LastName = lastNameTextBox.Text;
                    EmailAddress = emailAddressTextBox.Text;
                    string errorMessage = "";

                    if (!(FirstName == "") && !(LastName == "") && !(Adult == 0))

                    {
                        db.DeletePeople(Id, InstaHandle, FirstName, LastName, EmailAddress, Adult, Gender, EyeColor, SkinColor, HairColor, City, commentsRichTextBox.Text);
                        MessageBox.Show("Le model a bien été supprimé de la liste!");
                    }
                    else
                    {
                        MessageBox.Show("Merci d'indiquer le prenom, nom de famille et si le model est majeur ou mineur.");
                    }

                    if (!(errorMessage == ""))
                    {
                        MessageBox.Show(errorMessage);
                    }
                    LoadAllRecords();
                    Clear();
                    dataGridView1.DataSource = db.ViewPeople();
                    dataGridView1.Columns[0].Visible = false;
                //}
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un model pour le supprimer.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();

        }
    }
}

