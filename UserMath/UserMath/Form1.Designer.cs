namespace UserMath
{
    partial class User
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
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Lessons = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FLdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FLdButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.FLdName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(59, 450);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(100, 26);
            this.LoginText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(165, 450);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(100, 26);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // Lessons
            // 
            this.Lessons.FormattingEnabled = true;
            this.Lessons.Location = new System.Drawing.Point(-1, -3);
            this.Lessons.Name = "Lessons";
            this.Lessons.Size = new System.Drawing.Size(483, 446);
            this.Lessons.TabIndex = 4;
            this.Lessons.SelectedIndexChanged += new System.EventHandler(this.Lessons_SelectedIndexChanged);
            this.Lessons.DoubleClick += new System.EventHandler(this.Lessons_DoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(400, 59);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(319, 59);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Visible = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patch to Lessons";
            this.label1.Visible = false;
            // 
            // FLdButton
            // 
            this.FLdButton.Location = new System.Drawing.Point(95, 59);
            this.FLdButton.Name = "FLdButton";
            this.FLdButton.Size = new System.Drawing.Size(35, 23);
            this.FLdButton.TabIndex = 9;
            this.FLdButton.Text = ". . .";
            this.FLdButton.UseVisualStyleBackColor = true;
            this.FLdButton.Visible = false;
            this.FLdButton.Click += new System.EventHandler(this.FLdButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(271, 456);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Online";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FLdName
            // 
            this.FLdName.Location = new System.Drawing.Point(339, 33);
            this.FLdName.Name = "FLdName";
            this.FLdName.Size = new System.Drawing.Size(128, 20);
            this.FLdName.TabIndex = 7;
            this.FLdName.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reg";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.FLdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLdName);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Lessons);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Name = "User";
            this.Text = "Hello ";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.ListBox Lessons;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog FLdDialog;
        private System.Windows.Forms.Button FLdButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FLdName;
        private System.Windows.Forms.Button button2;
    }
}

