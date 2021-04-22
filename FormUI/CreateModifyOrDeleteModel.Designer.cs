
namespace FormUI
{
    partial class CreateModifyOrDeleteModel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.maleGenderRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleGenderRadioButton = new System.Windows.Forms.RadioButton();
            this.hairColorGroupBox = new System.Windows.Forms.GroupBox();
            this.blondHairColorRadioButton = new System.Windows.Forms.RadioButton();
            this.hazelHairColorRadioButton = new System.Windows.Forms.RadioButton();
            this.brownHairColorRadioButton = new System.Windows.Forms.RadioButton();
            this.skinColorGroupBox = new System.Windows.Forms.GroupBox();
            this.whiteSkinColorRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedSkinColorRadioButton = new System.Windows.Forms.RadioButton();
            this.blackSkinColorRadioButton = new System.Windows.Forms.RadioButton();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.eyeColorGroupBox = new System.Windows.Forms.GroupBox();
            this.blueEyeColorRadioButton = new System.Windows.Forms.RadioButton();
            this.greenEyeColorRadioButton = new System.Windows.Forms.RadioButton();
            this.brownEyeColorRadioButton = new System.Windows.Forms.RadioButton();
            this.blackEyeColorRadioButton = new System.Windows.Forms.RadioButton();
            this.cityGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonCity1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCity2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCity3 = new System.Windows.Forms.RadioButton();
            this.adultGroupBox = new System.Windows.Forms.GroupBox();
            this.noAdultRadioButton = new System.Windows.Forms.RadioButton();
            this.yesAdultRadioButton = new System.Windows.Forms.RadioButton();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.instaHandleLabel = new System.Windows.Forms.Label();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.instaHandleTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.hairColorGroupBox.SuspendLayout();
            this.skinColorGroupBox.SuspendLayout();
            this.eyeColorGroupBox.SuspendLayout();
            this.cityGroupBox.SuspendLayout();
            this.adultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 683);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.genderGroupBox);
            this.groupBox1.Controls.Add(this.hairColorGroupBox);
            this.groupBox1.Controls.Add(this.skinColorGroupBox);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.ModifyBtn);
            this.groupBox1.Controls.Add(this.eyeColorGroupBox);
            this.groupBox1.Controls.Add(this.cityGroupBox);
            this.groupBox1.Controls.Add(this.adultGroupBox);
            this.groupBox1.Controls.Add(this.emailAddressLabel);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(this.lastNameInsLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.instaHandleLabel);
            this.groupBox1.Controls.Add(this.firstNameInsLabel);
            this.groupBox1.Controls.Add(this.instaHandleTextBox);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 694);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter/Modifier/Supprimer un Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 42;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentsRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 86);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commentaires";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(7, 30);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(345, 45);
            this.commentsRichTextBox.TabIndex = 0;
            this.commentsRichTextBox.Text = "";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.maleGenderRadioButton);
            this.genderGroupBox.Controls.Add(this.femaleGenderRadioButton);
            this.genderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupBox.Location = new System.Drawing.Point(18, 193);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(253, 57);
            this.genderGroupBox.TabIndex = 39;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Genre";
            this.genderGroupBox.UseCompatibleTextRendering = true;
            // 
            // maleGenderRadioButton
            // 
            this.maleGenderRadioButton.AutoSize = true;
            this.maleGenderRadioButton.Location = new System.Drawing.Point(147, 22);
            this.maleGenderRadioButton.Name = "maleGenderRadioButton";
            this.maleGenderRadioButton.Size = new System.Drawing.Size(103, 29);
            this.maleGenderRadioButton.TabIndex = 1;
            this.maleGenderRadioButton.TabStop = true;
            this.maleGenderRadioButton.Text = "Homme";
            this.maleGenderRadioButton.UseVisualStyleBackColor = true;
            this.maleGenderRadioButton.CheckedChanged += new System.EventHandler(this.maleGenderRadioButton_CheckedChanged);
            // 
            // femaleGenderRadioButton
            // 
            this.femaleGenderRadioButton.AutoSize = true;
            this.femaleGenderRadioButton.Location = new System.Drawing.Point(11, 22);
            this.femaleGenderRadioButton.Name = "femaleGenderRadioButton";
            this.femaleGenderRadioButton.Size = new System.Drawing.Size(101, 29);
            this.femaleGenderRadioButton.TabIndex = 0;
            this.femaleGenderRadioButton.TabStop = true;
            this.femaleGenderRadioButton.Text = "Femme";
            this.femaleGenderRadioButton.UseVisualStyleBackColor = true;
            this.femaleGenderRadioButton.CheckedChanged += new System.EventHandler(this.femaleGenderRadioButton_CheckedChanged);
            // 
            // hairColorGroupBox
            // 
            this.hairColorGroupBox.Controls.Add(this.blondHairColorRadioButton);
            this.hairColorGroupBox.Controls.Add(this.hazelHairColorRadioButton);
            this.hairColorGroupBox.Controls.Add(this.brownHairColorRadioButton);
            this.hairColorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairColorGroupBox.Location = new System.Drawing.Point(18, 479);
            this.hairColorGroupBox.Name = "hairColorGroupBox";
            this.hairColorGroupBox.Size = new System.Drawing.Size(365, 59);
            this.hairColorGroupBox.TabIndex = 38;
            this.hairColorGroupBox.TabStop = false;
            this.hairColorGroupBox.Text = "Couleur de cheveux";
            // 
            // blondHairColorRadioButton
            // 
            this.blondHairColorRadioButton.AutoSize = true;
            this.blondHairColorRadioButton.Location = new System.Drawing.Point(13, 24);
            this.blondHairColorRadioButton.Name = "blondHairColorRadioButton";
            this.blondHairColorRadioButton.Size = new System.Drawing.Size(85, 29);
            this.blondHairColorRadioButton.TabIndex = 31;
            this.blondHairColorRadioButton.TabStop = true;
            this.blondHairColorRadioButton.Text = "Blond";
            this.blondHairColorRadioButton.UseVisualStyleBackColor = true;
            this.blondHairColorRadioButton.CheckedChanged += new System.EventHandler(this.blondHairColorRadioButton_CheckedChanged);
            // 
            // hazelHairColorRadioButton
            // 
            this.hazelHairColorRadioButton.AutoSize = true;
            this.hazelHairColorRadioButton.Location = new System.Drawing.Point(146, 24);
            this.hazelHairColorRadioButton.Name = "hazelHairColorRadioButton";
            this.hazelHairColorRadioButton.Size = new System.Drawing.Size(104, 29);
            this.hazelHairColorRadioButton.TabIndex = 32;
            this.hazelHairColorRadioButton.TabStop = true;
            this.hazelHairColorRadioButton.Text = "Chatain";
            this.hazelHairColorRadioButton.UseVisualStyleBackColor = true;
            this.hazelHairColorRadioButton.CheckedChanged += new System.EventHandler(this.hazelHairColorRadioButton_CheckedChanged);
            // 
            // brownHairColorRadioButton
            // 
            this.brownHairColorRadioButton.AutoSize = true;
            this.brownHairColorRadioButton.Location = new System.Drawing.Point(256, 23);
            this.brownHairColorRadioButton.Name = "brownHairColorRadioButton";
            this.brownHairColorRadioButton.Size = new System.Drawing.Size(98, 29);
            this.brownHairColorRadioButton.TabIndex = 33;
            this.brownHairColorRadioButton.TabStop = true;
            this.brownHairColorRadioButton.Text = "Marron";
            this.brownHairColorRadioButton.UseVisualStyleBackColor = true;
            this.brownHairColorRadioButton.CheckedChanged += new System.EventHandler(this.brownHairColorRadioButton_CheckedChanged);
            // 
            // skinColorGroupBox
            // 
            this.skinColorGroupBox.Controls.Add(this.whiteSkinColorRadioButton);
            this.skinColorGroupBox.Controls.Add(this.mixedSkinColorRadioButton);
            this.skinColorGroupBox.Controls.Add(this.blackSkinColorRadioButton);
            this.skinColorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinColorGroupBox.Location = new System.Drawing.Point(16, 420);
            this.skinColorGroupBox.Name = "skinColorGroupBox";
            this.skinColorGroupBox.Size = new System.Drawing.Size(367, 59);
            this.skinColorGroupBox.TabIndex = 37;
            this.skinColorGroupBox.TabStop = false;
            this.skinColorGroupBox.Text = "Couleur de peau";
            // 
            // whiteSkinColorRadioButton
            // 
            this.whiteSkinColorRadioButton.AutoSize = true;
            this.whiteSkinColorRadioButton.Location = new System.Drawing.Point(14, 24);
            this.whiteSkinColorRadioButton.Name = "whiteSkinColorRadioButton";
            this.whiteSkinColorRadioButton.Size = new System.Drawing.Size(84, 29);
            this.whiteSkinColorRadioButton.TabIndex = 27;
            this.whiteSkinColorRadioButton.TabStop = true;
            this.whiteSkinColorRadioButton.Text = "Blanc";
            this.whiteSkinColorRadioButton.UseVisualStyleBackColor = true;
            this.whiteSkinColorRadioButton.CheckedChanged += new System.EventHandler(this.whiteSkinColorRadioButton_CheckedChanged);
            // 
            // mixedSkinColorRadioButton
            // 
            this.mixedSkinColorRadioButton.AutoSize = true;
            this.mixedSkinColorRadioButton.Location = new System.Drawing.Point(149, 24);
            this.mixedSkinColorRadioButton.Name = "mixedSkinColorRadioButton";
            this.mixedSkinColorRadioButton.Size = new System.Drawing.Size(82, 29);
            this.mixedSkinColorRadioButton.TabIndex = 28;
            this.mixedSkinColorRadioButton.TabStop = true;
            this.mixedSkinColorRadioButton.Text = "Mixte";
            this.mixedSkinColorRadioButton.UseVisualStyleBackColor = true;
            this.mixedSkinColorRadioButton.CheckedChanged += new System.EventHandler(this.mixedSkinColorRadioButton_CheckedChanged);
            // 
            // blackSkinColorRadioButton
            // 
            this.blackSkinColorRadioButton.AutoSize = true;
            this.blackSkinColorRadioButton.Location = new System.Drawing.Point(256, 24);
            this.blackSkinColorRadioButton.Name = "blackSkinColorRadioButton";
            this.blackSkinColorRadioButton.Size = new System.Drawing.Size(69, 29);
            this.blackSkinColorRadioButton.TabIndex = 29;
            this.blackSkinColorRadioButton.TabStop = true;
            this.blackSkinColorRadioButton.Text = "Noir";
            this.blackSkinColorRadioButton.UseVisualStyleBackColor = true;
            this.blackSkinColorRadioButton.CheckedChanged += new System.EventHandler(this.blackSkinColorRadioButton_CheckedChanged);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(6, 646);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(143, 42);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AccessibleDescription = "";
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(294, 646);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 42);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBtn.Location = new System.Drawing.Point(155, 646);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(133, 42);
            this.ModifyBtn.TabIndex = 12;
            this.ModifyBtn.Text = "Modifier";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // eyeColorGroupBox
            // 
            this.eyeColorGroupBox.Controls.Add(this.blueEyeColorRadioButton);
            this.eyeColorGroupBox.Controls.Add(this.greenEyeColorRadioButton);
            this.eyeColorGroupBox.Controls.Add(this.brownEyeColorRadioButton);
            this.eyeColorGroupBox.Controls.Add(this.blackEyeColorRadioButton);
            this.eyeColorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeColorGroupBox.Location = new System.Drawing.Point(16, 361);
            this.eyeColorGroupBox.Name = "eyeColorGroupBox";
            this.eyeColorGroupBox.Size = new System.Drawing.Size(445, 59);
            this.eyeColorGroupBox.TabIndex = 36;
            this.eyeColorGroupBox.TabStop = false;
            this.eyeColorGroupBox.Text = "Couleur des yeux";
            // 
            // blueEyeColorRadioButton
            // 
            this.blueEyeColorRadioButton.AutoSize = true;
            this.blueEyeColorRadioButton.Location = new System.Drawing.Point(14, 24);
            this.blueEyeColorRadioButton.Name = "blueEyeColorRadioButton";
            this.blueEyeColorRadioButton.Size = new System.Drawing.Size(73, 29);
            this.blueEyeColorRadioButton.TabIndex = 22;
            this.blueEyeColorRadioButton.TabStop = true;
            this.blueEyeColorRadioButton.Text = "Bleu";
            this.blueEyeColorRadioButton.UseVisualStyleBackColor = true;
            this.blueEyeColorRadioButton.CheckedChanged += new System.EventHandler(this.blueEyeColorRadioButton_CheckedChanged);
            // 
            // greenEyeColorRadioButton
            // 
            this.greenEyeColorRadioButton.AutoSize = true;
            this.greenEyeColorRadioButton.Location = new System.Drawing.Point(149, 24);
            this.greenEyeColorRadioButton.Name = "greenEyeColorRadioButton";
            this.greenEyeColorRadioButton.Size = new System.Drawing.Size(69, 29);
            this.greenEyeColorRadioButton.TabIndex = 23;
            this.greenEyeColorRadioButton.TabStop = true;
            this.greenEyeColorRadioButton.Text = "Vert";
            this.greenEyeColorRadioButton.UseVisualStyleBackColor = true;
            this.greenEyeColorRadioButton.CheckedChanged += new System.EventHandler(this.greenEyeColorRadioButton_CheckedChanged);
            // 
            // brownEyeColorRadioButton
            // 
            this.brownEyeColorRadioButton.AutoSize = true;
            this.brownEyeColorRadioButton.Location = new System.Drawing.Point(256, 24);
            this.brownEyeColorRadioButton.Name = "brownEyeColorRadioButton";
            this.brownEyeColorRadioButton.Size = new System.Drawing.Size(98, 29);
            this.brownEyeColorRadioButton.TabIndex = 24;
            this.brownEyeColorRadioButton.TabStop = true;
            this.brownEyeColorRadioButton.Text = "Marron";
            this.brownEyeColorRadioButton.UseVisualStyleBackColor = true;
            this.brownEyeColorRadioButton.CheckedChanged += new System.EventHandler(this.brownEyeColorRadioButton_CheckedChanged);
            // 
            // blackEyeColorRadioButton
            // 
            this.blackEyeColorRadioButton.AutoSize = true;
            this.blackEyeColorRadioButton.Location = new System.Drawing.Point(370, 24);
            this.blackEyeColorRadioButton.Name = "blackEyeColorRadioButton";
            this.blackEyeColorRadioButton.Size = new System.Drawing.Size(69, 29);
            this.blackEyeColorRadioButton.TabIndex = 25;
            this.blackEyeColorRadioButton.TabStop = true;
            this.blackEyeColorRadioButton.Text = "Noir";
            this.blackEyeColorRadioButton.UseVisualStyleBackColor = true;
            this.blackEyeColorRadioButton.CheckedChanged += new System.EventHandler(this.blackEyeColorRadioButton_CheckedChanged);
            // 
            // cityGroupBox
            // 
            this.cityGroupBox.Controls.Add(this.radioButtonCity1);
            this.cityGroupBox.Controls.Add(this.radioButtonCity2);
            this.cityGroupBox.Controls.Add(this.radioButtonCity3);
            this.cityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityGroupBox.Location = new System.Drawing.Point(16, 306);
            this.cityGroupBox.Name = "cityGroupBox";
            this.cityGroupBox.Size = new System.Drawing.Size(365, 59);
            this.cityGroupBox.TabIndex = 35;
            this.cityGroupBox.TabStop = false;
            this.cityGroupBox.Text = "Ville";
            // 
            // radioButtonCity1
            // 
            this.radioButtonCity1.AutoSize = true;
            this.radioButtonCity1.Location = new System.Drawing.Point(14, 24);
            this.radioButtonCity1.Name = "radioButtonCity1";
            this.radioButtonCity1.Size = new System.Drawing.Size(91, 29);
            this.radioButtonCity1.TabIndex = 18;
            this.radioButtonCity1.TabStop = true;
            this.radioButtonCity1.Text = "Nancy";
            this.radioButtonCity1.UseVisualStyleBackColor = true;
            this.radioButtonCity1.CheckedChanged += new System.EventHandler(this.radioButtonCity1_CheckedChanged);
            // 
            // radioButtonCity2
            // 
            this.radioButtonCity2.AutoSize = true;
            this.radioButtonCity2.Location = new System.Drawing.Point(149, 24);
            this.radioButtonCity2.Name = "radioButtonCity2";
            this.radioButtonCity2.Size = new System.Drawing.Size(77, 29);
            this.radioButtonCity2.TabIndex = 19;
            this.radioButtonCity2.TabStop = true;
            this.radioButtonCity2.Text = "Metz";
            this.radioButtonCity2.UseVisualStyleBackColor = true;
            this.radioButtonCity2.CheckedChanged += new System.EventHandler(this.radioButtonCity2_CheckedChanged);
            // 
            // radioButtonCity3
            // 
            this.radioButtonCity3.AutoSize = true;
            this.radioButtonCity3.Location = new System.Drawing.Point(256, 24);
            this.radioButtonCity3.Name = "radioButtonCity3";
            this.radioButtonCity3.Size = new System.Drawing.Size(79, 29);
            this.radioButtonCity3.TabIndex = 20;
            this.radioButtonCity3.TabStop = true;
            this.radioButtonCity3.Text = "Paris";
            this.radioButtonCity3.UseVisualStyleBackColor = true;
            this.radioButtonCity3.CheckedChanged += new System.EventHandler(this.radioButtonCity3_CheckedChanged);
            // 
            // adultGroupBox
            // 
            this.adultGroupBox.Controls.Add(this.noAdultRadioButton);
            this.adultGroupBox.Controls.Add(this.yesAdultRadioButton);
            this.adultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultGroupBox.Location = new System.Drawing.Point(16, 250);
            this.adultGroupBox.Name = "adultGroupBox";
            this.adultGroupBox.Size = new System.Drawing.Size(255, 59);
            this.adultGroupBox.TabIndex = 34;
            this.adultGroupBox.TabStop = false;
            this.adultGroupBox.Text = "Majeur?*";
            // 
            // noAdultRadioButton
            // 
            this.noAdultRadioButton.AutoSize = true;
            this.noAdultRadioButton.Location = new System.Drawing.Point(149, 24);
            this.noAdultRadioButton.Name = "noAdultRadioButton";
            this.noAdultRadioButton.Size = new System.Drawing.Size(69, 29);
            this.noAdultRadioButton.TabIndex = 16;
            this.noAdultRadioButton.TabStop = true;
            this.noAdultRadioButton.Text = "Non";
            this.noAdultRadioButton.UseVisualStyleBackColor = true;
            this.noAdultRadioButton.CheckedChanged += new System.EventHandler(this.noAdultRadioButton_CheckedChanged);
            // 
            // yesAdultRadioButton
            // 
            this.yesAdultRadioButton.AutoSize = true;
            this.yesAdultRadioButton.Location = new System.Drawing.Point(14, 24);
            this.yesAdultRadioButton.Name = "yesAdultRadioButton";
            this.yesAdultRadioButton.Size = new System.Drawing.Size(63, 29);
            this.yesAdultRadioButton.TabIndex = 17;
            this.yesAdultRadioButton.TabStop = true;
            this.yesAdultRadioButton.Text = "Oui";
            this.yesAdultRadioButton.UseVisualStyleBackColor = true;
            this.yesAdultRadioButton.CheckedChanged += new System.EventHandler(this.yesAdultRadioButton_CheckedChanged);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(20, 150);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(136, 25);
            this.emailAddressLabel.TabIndex = 9;
            this.emailAddressLabel.Text = "Adresse mail";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(234, 150);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(197, 31);
            this.emailAddressTextBox.TabIndex = 8;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInsLabel.Location = new System.Drawing.Point(20, 113);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(162, 25);
            this.lastNameInsLabel.TabIndex = 7;
            this.lastNameInsLabel.Text = "Nom de famille*";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(234, 113);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 31);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // instaHandleLabel
            // 
            this.instaHandleLabel.AutoSize = true;
            this.instaHandleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instaHandleLabel.Location = new System.Drawing.Point(20, 42);
            this.instaHandleLabel.Name = "instaHandleLabel";
            this.instaHandleLabel.Size = new System.Drawing.Size(127, 25);
            this.instaHandleLabel.TabIndex = 5;
            this.instaHandleLabel.Text = "@instagram";
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInsLabel.Location = new System.Drawing.Point(20, 76);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(94, 25);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "Prénom*";
            // 
            // instaHandleTextBox
            // 
            this.instaHandleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instaHandleTextBox.Location = new System.Drawing.Point(234, 39);
            this.instaHandleTextBox.Name = "instaHandleTextBox";
            this.instaHandleTextBox.Size = new System.Drawing.Size(197, 31);
            this.instaHandleTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(234, 76);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 31);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // CreateModifyOrDeleteModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateModifyOrDeleteModel";
            this.Text = "Ajout, Modification et Suppression de Models";
            this.Load += new System.EventHandler(this.ModifyOrDeleteModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.hairColorGroupBox.ResumeLayout(false);
            this.hairColorGroupBox.PerformLayout();
            this.skinColorGroupBox.ResumeLayout(false);
            this.skinColorGroupBox.PerformLayout();
            this.eyeColorGroupBox.ResumeLayout(false);
            this.eyeColorGroupBox.PerformLayout();
            this.cityGroupBox.ResumeLayout(false);
            this.cityGroupBox.PerformLayout();
            this.adultGroupBox.ResumeLayout(false);
            this.adultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton maleGenderRadioButton;
        private System.Windows.Forms.RadioButton femaleGenderRadioButton;
        private System.Windows.Forms.GroupBox hairColorGroupBox;
        private System.Windows.Forms.RadioButton blondHairColorRadioButton;
        private System.Windows.Forms.RadioButton hazelHairColorRadioButton;
        private System.Windows.Forms.RadioButton brownHairColorRadioButton;
        private System.Windows.Forms.GroupBox skinColorGroupBox;
        private System.Windows.Forms.RadioButton whiteSkinColorRadioButton;
        private System.Windows.Forms.RadioButton mixedSkinColorRadioButton;
        private System.Windows.Forms.RadioButton blackSkinColorRadioButton;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.GroupBox eyeColorGroupBox;
        private System.Windows.Forms.RadioButton blueEyeColorRadioButton;
        private System.Windows.Forms.RadioButton greenEyeColorRadioButton;
        private System.Windows.Forms.RadioButton brownEyeColorRadioButton;
        private System.Windows.Forms.RadioButton blackEyeColorRadioButton;
        private System.Windows.Forms.GroupBox cityGroupBox;
        private System.Windows.Forms.RadioButton radioButtonCity1;
        private System.Windows.Forms.RadioButton radioButtonCity2;
        private System.Windows.Forms.RadioButton radioButtonCity3;
        private System.Windows.Forms.GroupBox adultGroupBox;
        private System.Windows.Forms.RadioButton noAdultRadioButton;
        private System.Windows.Forms.RadioButton yesAdultRadioButton;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instaHandleLabel;
        private System.Windows.Forms.TextBox instaHandleTextBox;
        private System.Windows.Forms.Button button1;
    }
}