namespace XML_Movie_Manager
{
    partial class Form1
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
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.addPathTextBox = new System.Windows.Forms.TextBox();
            this.addRatingTextBox = new System.Windows.Forms.TextBox();
            this.addDirectorTextBox = new System.Windows.Forms.TextBox();
            this.addLengthTextBox = new System.Windows.Forms.TextBox();
            this.addYearTextBox = new System.Windows.Forms.TextBox();
            this.addTitleTextBox = new System.Windows.Forms.TextBox();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(12, 187);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(225, 160);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.Location = new System.Drawing.Point(12, 38);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(225, 121);
            this.genreListBox.TabIndex = 1;
            this.genreListBox.SelectedIndexChanged += new System.EventHandler(this.genreListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Director:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rating:";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(68, 374);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(99, 23);
            this.modifyButton.TabIndex = 18;
            this.modifyButton.Text = "Modify selection";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(68, 456);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save modification";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(68, 533);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 23);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(68, 494);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 23);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add new movie";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.addPathTextBox);
            this.groupBox2.Controls.Add(this.addRatingTextBox);
            this.groupBox2.Controls.Add(this.addDirectorTextBox);
            this.groupBox2.Controls.Add(this.addLengthTextBox);
            this.groupBox2.Controls.Add(this.addYearTextBox);
            this.groupBox2.Controls.Add(this.addTitleTextBox);
            this.groupBox2.Controls.Add(this.addGenreTextBox);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Location = new System.Drawing.Point(255, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 202);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Path:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Rating:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Director:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "length:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Year:";
            // 
            // addPathTextBox
            // 
            this.addPathTextBox.Location = new System.Drawing.Point(48, 173);
            this.addPathTextBox.Name = "addPathTextBox";
            this.addPathTextBox.Size = new System.Drawing.Size(265, 20);
            this.addPathTextBox.TabIndex = 26;
            // 
            // addRatingTextBox
            // 
            this.addRatingTextBox.Location = new System.Drawing.Point(48, 147);
            this.addRatingTextBox.Name = "addRatingTextBox";
            this.addRatingTextBox.Size = new System.Drawing.Size(265, 20);
            this.addRatingTextBox.TabIndex = 25;
            // 
            // addDirectorTextBox
            // 
            this.addDirectorTextBox.Location = new System.Drawing.Point(48, 121);
            this.addDirectorTextBox.Name = "addDirectorTextBox";
            this.addDirectorTextBox.Size = new System.Drawing.Size(265, 20);
            this.addDirectorTextBox.TabIndex = 24;
            // 
            // addLengthTextBox
            // 
            this.addLengthTextBox.Location = new System.Drawing.Point(48, 95);
            this.addLengthTextBox.Name = "addLengthTextBox";
            this.addLengthTextBox.Size = new System.Drawing.Size(265, 20);
            this.addLengthTextBox.TabIndex = 23;
            // 
            // addYearTextBox
            // 
            this.addYearTextBox.Location = new System.Drawing.Point(48, 69);
            this.addYearTextBox.Name = "addYearTextBox";
            this.addYearTextBox.Size = new System.Drawing.Size(265, 20);
            this.addYearTextBox.TabIndex = 22;
            // 
            // addTitleTextBox
            // 
            this.addTitleTextBox.Location = new System.Drawing.Point(48, 43);
            this.addTitleTextBox.Name = "addTitleTextBox";
            this.addTitleTextBox.Size = new System.Drawing.Size(265, 20);
            this.addTitleTextBox.TabIndex = 21;
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(48, 17);
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(265, 20);
            this.addGenreTextBox.TabIndex = 20;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 19;
            this.label27.Text = "Title:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Genre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 148);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(68, 416);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 23);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete selection";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(461, 261);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(113, 20);
            this.ratingTextBox.TabIndex = 31;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(300, 261);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(108, 20);
            this.directorTextBox.TabIndex = 30;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(461, 225);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(113, 20);
            this.lengthTextBox.TabIndex = 29;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(300, 225);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(108, 20);
            this.yearTextBox.TabIndex = 28;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(300, 187);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(274, 20);
            this.titleTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Movie:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(300, 152);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(97, 20);
            this.genreTextBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Genre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(300, 296);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(274, 20);
            this.pathTextBox.TabIndex = 28;
            // 
            // showAllButton
            // 
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.Location = new System.Drawing.Point(182, 12);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(55, 20);
            this.showAllButton.TabIndex = 33;
            this.showAllButton.Text = "Show all";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 577);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.movieListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Movies Manager";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox addPathTextBox;
        private System.Windows.Forms.TextBox addRatingTextBox;
        private System.Windows.Forms.TextBox addDirectorTextBox;
        private System.Windows.Forms.TextBox addLengthTextBox;
        private System.Windows.Forms.TextBox addYearTextBox;
        private System.Windows.Forms.TextBox addTitleTextBox;
        private System.Windows.Forms.TextBox addGenreTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button showAllButton;
    }
}

