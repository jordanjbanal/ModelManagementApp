namespace FormUI
{
    partial class Dashboard
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterSearchButton = new System.Windows.Forms.Button();
            this.skinColorFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.whiteSkinColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedSkinColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.blackSkinColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.blondHairColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.hazelHairColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.brownHairColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.hairColorFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.blueEyeColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.greenEyeColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.brownEyeColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.blackEyeColorFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.eyeColorFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.filterRadioButtonCity1 = new System.Windows.Forms.RadioButton();
            this.filterRadioButtonCity2 = new System.Windows.Forms.RadioButton();
            this.filterRadioButtonCity3 = new System.Windows.Forms.RadioButton();
            this.cityFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.noAdultFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.yesAdultFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.ageFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.genderFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maleFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(32, 40);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(197, 31);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(245, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Recherche";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "Model Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(290, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 90);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par mots cles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterSearchButton);
            this.groupBox2.Controls.Add(this.skinColorFilterCheckBox);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.hairColorFilterCheckBox);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.eyeColorFilterCheckBox);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.cityFilterCheckBox);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.ageFilterCheckBox);
            this.groupBox2.Controls.Add(this.genderFilterCheckBox);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(29, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 561);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche avec filtres";
            // 
            // filterSearchButton
            // 
            this.filterSearchButton.Location = new System.Drawing.Point(199, 503);
            this.filterSearchButton.Name = "filterSearchButton";
            this.filterSearchButton.Size = new System.Drawing.Size(133, 42);
            this.filterSearchButton.TabIndex = 12;
            this.filterSearchButton.Text = "Recherche";
            this.filterSearchButton.UseVisualStyleBackColor = true;
            this.filterSearchButton.Click += new System.EventHandler(this.filterSearchButton_Click);
            // 
            // skinColorFilterCheckBox
            // 
            this.skinColorFilterCheckBox.AutoSize = true;
            this.skinColorFilterCheckBox.Location = new System.Drawing.Point(32, 360);
            this.skinColorFilterCheckBox.Name = "skinColorFilterCheckBox";
            this.skinColorFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.skinColorFilterCheckBox.TabIndex = 11;
            this.skinColorFilterCheckBox.UseVisualStyleBackColor = true;
            this.skinColorFilterCheckBox.CheckedChanged += new System.EventHandler(this.skinColorFilterCheckBox_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.whiteSkinColorFilterRadioButton);
            this.groupBox9.Controls.Add(this.mixedSkinColorFilterRadioButton);
            this.groupBox9.Controls.Add(this.blackSkinColorFilterRadioButton);
            this.groupBox9.Location = new System.Drawing.Point(67, 330);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(393, 79);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Couleur de peau";
            // 
            // whiteSkinColorFilterRadioButton
            // 
            this.whiteSkinColorFilterRadioButton.AutoSize = true;
            this.whiteSkinColorFilterRadioButton.Location = new System.Drawing.Point(14, 30);
            this.whiteSkinColorFilterRadioButton.Name = "whiteSkinColorFilterRadioButton";
            this.whiteSkinColorFilterRadioButton.Size = new System.Drawing.Size(84, 29);
            this.whiteSkinColorFilterRadioButton.TabIndex = 30;
            this.whiteSkinColorFilterRadioButton.TabStop = true;
            this.whiteSkinColorFilterRadioButton.Text = "Blanc";
            this.whiteSkinColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // mixedSkinColorFilterRadioButton
            // 
            this.mixedSkinColorFilterRadioButton.AutoSize = true;
            this.mixedSkinColorFilterRadioButton.Location = new System.Drawing.Point(149, 30);
            this.mixedSkinColorFilterRadioButton.Name = "mixedSkinColorFilterRadioButton";
            this.mixedSkinColorFilterRadioButton.Size = new System.Drawing.Size(82, 29);
            this.mixedSkinColorFilterRadioButton.TabIndex = 31;
            this.mixedSkinColorFilterRadioButton.TabStop = true;
            this.mixedSkinColorFilterRadioButton.Text = "Mixte";
            this.mixedSkinColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackSkinColorFilterRadioButton
            // 
            this.blackSkinColorFilterRadioButton.AutoSize = true;
            this.blackSkinColorFilterRadioButton.Location = new System.Drawing.Point(286, 30);
            this.blackSkinColorFilterRadioButton.Name = "blackSkinColorFilterRadioButton";
            this.blackSkinColorFilterRadioButton.Size = new System.Drawing.Size(69, 29);
            this.blackSkinColorFilterRadioButton.TabIndex = 32;
            this.blackSkinColorFilterRadioButton.TabStop = true;
            this.blackSkinColorFilterRadioButton.Text = "Noir";
            this.blackSkinColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.blondHairColorFilterRadioButton);
            this.groupBox8.Controls.Add(this.hazelHairColorFilterRadioButton);
            this.groupBox8.Controls.Add(this.brownHairColorFilterRadioButton);
            this.groupBox8.Location = new System.Drawing.Point(67, 415);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(393, 72);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Couleur de cheveux";
            // 
            // blondHairColorFilterRadioButton
            // 
            this.blondHairColorFilterRadioButton.AutoSize = true;
            this.blondHairColorFilterRadioButton.Location = new System.Drawing.Point(16, 30);
            this.blondHairColorFilterRadioButton.Name = "blondHairColorFilterRadioButton";
            this.blondHairColorFilterRadioButton.Size = new System.Drawing.Size(85, 29);
            this.blondHairColorFilterRadioButton.TabIndex = 34;
            this.blondHairColorFilterRadioButton.TabStop = true;
            this.blondHairColorFilterRadioButton.Text = "Blond";
            this.blondHairColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // hazelHairColorFilterRadioButton
            // 
            this.hazelHairColorFilterRadioButton.AutoSize = true;
            this.hazelHairColorFilterRadioButton.Location = new System.Drawing.Point(149, 30);
            this.hazelHairColorFilterRadioButton.Name = "hazelHairColorFilterRadioButton";
            this.hazelHairColorFilterRadioButton.Size = new System.Drawing.Size(104, 29);
            this.hazelHairColorFilterRadioButton.TabIndex = 35;
            this.hazelHairColorFilterRadioButton.TabStop = true;
            this.hazelHairColorFilterRadioButton.Text = "Chatain";
            this.hazelHairColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // brownHairColorFilterRadioButton
            // 
            this.brownHairColorFilterRadioButton.AutoSize = true;
            this.brownHairColorFilterRadioButton.Location = new System.Drawing.Point(286, 30);
            this.brownHairColorFilterRadioButton.Name = "brownHairColorFilterRadioButton";
            this.brownHairColorFilterRadioButton.Size = new System.Drawing.Size(98, 29);
            this.brownHairColorFilterRadioButton.TabIndex = 36;
            this.brownHairColorFilterRadioButton.TabStop = true;
            this.brownHairColorFilterRadioButton.Text = "Marron";
            this.brownHairColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // hairColorFilterCheckBox
            // 
            this.hairColorFilterCheckBox.AutoSize = true;
            this.hairColorFilterCheckBox.Location = new System.Drawing.Point(32, 436);
            this.hairColorFilterCheckBox.Name = "hairColorFilterCheckBox";
            this.hairColorFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hairColorFilterCheckBox.TabIndex = 8;
            this.hairColorFilterCheckBox.UseVisualStyleBackColor = true;
            this.hairColorFilterCheckBox.CheckedChanged += new System.EventHandler(this.hairColorFilterCheckBox_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.blueEyeColorFilterRadioButton);
            this.groupBox7.Controls.Add(this.greenEyeColorFilterRadioButton);
            this.groupBox7.Controls.Add(this.brownEyeColorFilterRadioButton);
            this.groupBox7.Controls.Add(this.blackEyeColorFilterRadioButton);
            this.groupBox7.Location = new System.Drawing.Point(67, 253);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(551, 70);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Couleur des yeux";
            // 
            // blueEyeColorFilterRadioButton
            // 
            this.blueEyeColorFilterRadioButton.AutoSize = true;
            this.blueEyeColorFilterRadioButton.Location = new System.Drawing.Point(14, 30);
            this.blueEyeColorFilterRadioButton.Name = "blueEyeColorFilterRadioButton";
            this.blueEyeColorFilterRadioButton.Size = new System.Drawing.Size(73, 29);
            this.blueEyeColorFilterRadioButton.TabIndex = 26;
            this.blueEyeColorFilterRadioButton.TabStop = true;
            this.blueEyeColorFilterRadioButton.Text = "Bleu";
            this.blueEyeColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // greenEyeColorFilterRadioButton
            // 
            this.greenEyeColorFilterRadioButton.AutoSize = true;
            this.greenEyeColorFilterRadioButton.Location = new System.Drawing.Point(149, 30);
            this.greenEyeColorFilterRadioButton.Name = "greenEyeColorFilterRadioButton";
            this.greenEyeColorFilterRadioButton.Size = new System.Drawing.Size(69, 29);
            this.greenEyeColorFilterRadioButton.TabIndex = 27;
            this.greenEyeColorFilterRadioButton.TabStop = true;
            this.greenEyeColorFilterRadioButton.Text = "Vert";
            this.greenEyeColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // brownEyeColorFilterRadioButton
            // 
            this.brownEyeColorFilterRadioButton.AutoSize = true;
            this.brownEyeColorFilterRadioButton.Location = new System.Drawing.Point(286, 30);
            this.brownEyeColorFilterRadioButton.Name = "brownEyeColorFilterRadioButton";
            this.brownEyeColorFilterRadioButton.Size = new System.Drawing.Size(98, 29);
            this.brownEyeColorFilterRadioButton.TabIndex = 28;
            this.brownEyeColorFilterRadioButton.TabStop = true;
            this.brownEyeColorFilterRadioButton.Text = "Marron";
            this.brownEyeColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackEyeColorFilterRadioButton
            // 
            this.blackEyeColorFilterRadioButton.AutoSize = true;
            this.blackEyeColorFilterRadioButton.Location = new System.Drawing.Point(437, 30);
            this.blackEyeColorFilterRadioButton.Name = "blackEyeColorFilterRadioButton";
            this.blackEyeColorFilterRadioButton.Size = new System.Drawing.Size(69, 29);
            this.blackEyeColorFilterRadioButton.TabIndex = 29;
            this.blackEyeColorFilterRadioButton.TabStop = true;
            this.blackEyeColorFilterRadioButton.Text = "Noir";
            this.blackEyeColorFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // eyeColorFilterCheckBox
            // 
            this.eyeColorFilterCheckBox.AutoSize = true;
            this.eyeColorFilterCheckBox.Location = new System.Drawing.Point(32, 291);
            this.eyeColorFilterCheckBox.Name = "eyeColorFilterCheckBox";
            this.eyeColorFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.eyeColorFilterCheckBox.TabIndex = 6;
            this.eyeColorFilterCheckBox.UseVisualStyleBackColor = true;
            this.eyeColorFilterCheckBox.CheckedChanged += new System.EventHandler(this.eyeColorFilterCheckBox_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.filterRadioButtonCity1);
            this.groupBox6.Controls.Add(this.filterRadioButtonCity2);
            this.groupBox6.Controls.Add(this.filterRadioButtonCity3);
            this.groupBox6.Location = new System.Drawing.Point(67, 179);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(393, 68);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtrer par ville";
            // 
            // filterRadioButtonCity1
            // 
            this.filterRadioButtonCity1.AutoSize = true;
            this.filterRadioButtonCity1.Location = new System.Drawing.Point(18, 30);
            this.filterRadioButtonCity1.Name = "filterRadioButtonCity1";
            this.filterRadioButtonCity1.Size = new System.Drawing.Size(91, 29);
            this.filterRadioButtonCity1.TabIndex = 21;
            this.filterRadioButtonCity1.TabStop = true;
            this.filterRadioButtonCity1.Text = "Nancy";
            this.filterRadioButtonCity1.UseVisualStyleBackColor = true;
            // 
            // filterRadioButtonCity2
            // 
            this.filterRadioButtonCity2.AutoSize = true;
            this.filterRadioButtonCity2.Location = new System.Drawing.Point(149, 30);
            this.filterRadioButtonCity2.Name = "filterRadioButtonCity2";
            this.filterRadioButtonCity2.Size = new System.Drawing.Size(77, 29);
            this.filterRadioButtonCity2.TabIndex = 22;
            this.filterRadioButtonCity2.TabStop = true;
            this.filterRadioButtonCity2.Text = "Metz";
            this.filterRadioButtonCity2.UseVisualStyleBackColor = true;
            // 
            // filterRadioButtonCity3
            // 
            this.filterRadioButtonCity3.AutoSize = true;
            this.filterRadioButtonCity3.Location = new System.Drawing.Point(286, 30);
            this.filterRadioButtonCity3.Name = "filterRadioButtonCity3";
            this.filterRadioButtonCity3.Size = new System.Drawing.Size(79, 29);
            this.filterRadioButtonCity3.TabIndex = 23;
            this.filterRadioButtonCity3.TabStop = true;
            this.filterRadioButtonCity3.Text = "Paris";
            this.filterRadioButtonCity3.UseVisualStyleBackColor = true;
            // 
            // cityFilterCheckBox
            // 
            this.cityFilterCheckBox.AutoSize = true;
            this.cityFilterCheckBox.Location = new System.Drawing.Point(32, 217);
            this.cityFilterCheckBox.Name = "cityFilterCheckBox";
            this.cityFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.cityFilterCheckBox.TabIndex = 4;
            this.cityFilterCheckBox.UseVisualStyleBackColor = true;
            this.cityFilterCheckBox.CheckedChanged += new System.EventHandler(this.cityFilterCheckBox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.noAdultFilterRadioButton);
            this.groupBox5.Controls.Add(this.yesAdultFilterRadioButton);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Location = new System.Drawing.Point(67, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 59);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtrer par age";
            // 
            // noAdultFilterRadioButton
            // 
            this.noAdultFilterRadioButton.AutoSize = true;
            this.noAdultFilterRadioButton.Location = new System.Drawing.Point(149, 25);
            this.noAdultFilterRadioButton.Name = "noAdultFilterRadioButton";
            this.noAdultFilterRadioButton.Size = new System.Drawing.Size(96, 29);
            this.noAdultFilterRadioButton.TabIndex = 2;
            this.noAdultFilterRadioButton.TabStop = true;
            this.noAdultFilterRadioButton.Text = "Majeur";
            this.noAdultFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesAdultFilterRadioButton
            // 
            this.yesAdultFilterRadioButton.AutoSize = true;
            this.yesAdultFilterRadioButton.Location = new System.Drawing.Point(27, 25);
            this.yesAdultFilterRadioButton.Name = "yesAdultFilterRadioButton";
            this.yesAdultFilterRadioButton.Size = new System.Drawing.Size(96, 29);
            this.yesAdultFilterRadioButton.TabIndex = 1;
            this.yesAdultFilterRadioButton.TabStop = true;
            this.yesAdultFilterRadioButton.Text = "Mineur";
            this.yesAdultFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(-28, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // ageFilterCheckBox
            // 
            this.ageFilterCheckBox.AutoSize = true;
            this.ageFilterCheckBox.Location = new System.Drawing.Point(32, 144);
            this.ageFilterCheckBox.Name = "ageFilterCheckBox";
            this.ageFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ageFilterCheckBox.TabIndex = 3;
            this.ageFilterCheckBox.UseVisualStyleBackColor = true;
            this.ageFilterCheckBox.CheckedChanged += new System.EventHandler(this.ageFilterCheckBox_CheckedChanged);
            // 
            // genderFilterCheckBox
            // 
            this.genderFilterCheckBox.AutoSize = true;
            this.genderFilterCheckBox.Location = new System.Drawing.Point(32, 74);
            this.genderFilterCheckBox.Name = "genderFilterCheckBox";
            this.genderFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.genderFilterCheckBox.TabIndex = 2;
            this.genderFilterCheckBox.UseVisualStyleBackColor = true;
            this.genderFilterCheckBox.CheckedChanged += new System.EventHandler(this.genderFilterCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maleFilterRadioButton);
            this.groupBox4.Controls.Add(this.femaleFilterRadioButton);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(67, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 59);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrer par genre";
            // 
            // maleFilterRadioButton
            // 
            this.maleFilterRadioButton.AutoSize = true;
            this.maleFilterRadioButton.Location = new System.Drawing.Point(149, 25);
            this.maleFilterRadioButton.Name = "maleFilterRadioButton";
            this.maleFilterRadioButton.Size = new System.Drawing.Size(116, 29);
            this.maleFilterRadioButton.TabIndex = 2;
            this.maleFilterRadioButton.TabStop = true;
            this.maleFilterRadioButton.Text = "Masculin";
            this.maleFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleFilterRadioButton
            // 
            this.femaleFilterRadioButton.AutoSize = true;
            this.femaleFilterRadioButton.Location = new System.Drawing.Point(27, 25);
            this.femaleFilterRadioButton.Name = "femaleFilterRadioButton";
            this.femaleFilterRadioButton.Size = new System.Drawing.Size(106, 29);
            this.femaleFilterRadioButton.TabIndex = 1;
            this.femaleFilterRadioButton.TabStop = true;
            this.femaleFilterRadioButton.Text = "Feminin";
            this.femaleFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-28, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(29, 672);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 80);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 34);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ajouter/Modifier/Supprimer Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(709, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1175, 731);
            this.dataGridView1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Version 1.0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 765);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Application de gestion de models (Version 1.0)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cityFilterCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton noAdultFilterRadioButton;
        private System.Windows.Forms.RadioButton yesAdultFilterRadioButton;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox ageFilterCheckBox;
        private System.Windows.Forms.CheckBox genderFilterCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton maleFilterRadioButton;
        private System.Windows.Forms.RadioButton femaleFilterRadioButton;
        private System.Windows.Forms.RadioButton filterRadioButtonCity1;
        private System.Windows.Forms.RadioButton filterRadioButtonCity2;
        private System.Windows.Forms.RadioButton filterRadioButtonCity3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox eyeColorFilterCheckBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox hairColorFilterCheckBox;
        private System.Windows.Forms.RadioButton blueEyeColorFilterRadioButton;
        private System.Windows.Forms.RadioButton greenEyeColorFilterRadioButton;
        private System.Windows.Forms.RadioButton brownEyeColorFilterRadioButton;
        private System.Windows.Forms.RadioButton blackEyeColorFilterRadioButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton blondHairColorFilterRadioButton;
        private System.Windows.Forms.RadioButton hazelHairColorFilterRadioButton;
        private System.Windows.Forms.RadioButton brownHairColorFilterRadioButton;
        private System.Windows.Forms.Button filterSearchButton;
        private System.Windows.Forms.CheckBox skinColorFilterCheckBox;
        private System.Windows.Forms.RadioButton whiteSkinColorFilterRadioButton;
        private System.Windows.Forms.RadioButton mixedSkinColorFilterRadioButton;
        private System.Windows.Forms.RadioButton blackSkinColorFilterRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

