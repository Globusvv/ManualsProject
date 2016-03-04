namespace ServerMath1
{
    partial class Server
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
            this.Lessons = new System.Windows.Forms.ListBox();
            this.FLdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FLdButton = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Tests = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FLdName1 = new System.Windows.Forms.TextBox();
            this.FLdButton1 = new System.Windows.Forms.Button();
            this.Remove1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.OnlineUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lessons
            // 
            this.Lessons.FormattingEnabled = true;
            this.Lessons.Location = new System.Drawing.Point(12, 32);
            this.Lessons.Name = "Lessons";
            this.Lessons.Size = new System.Drawing.Size(204, 433);
            this.Lessons.TabIndex = 0;
            this.Lessons.DoubleClick += new System.EventHandler(this.Lessons_DoubleClick);
            // 
            // FLdName
            // 
            this.FLdName.Location = new System.Drawing.Point(103, 6);
            this.FLdName.Name = "FLdName";
            this.FLdName.Size = new System.Drawing.Size(254, 20);
            this.FLdName.TabIndex = 1;
            this.FLdName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patch to Lessons";
            // 
            // FLdButton
            // 
            this.FLdButton.Location = new System.Drawing.Point(107, 3);
            this.FLdButton.Name = "FLdButton";
            this.FLdButton.Size = new System.Drawing.Size(34, 23);
            this.FLdButton.TabIndex = 3;
            this.FLdButton.Text = ". . .";
            this.FLdButton.UseVisualStyleBackColor = true;
            this.FLdButton.Click += new System.EventHandler(this.FLdButton_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(12, 471);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Tests
            // 
            this.Tests.FormattingEnabled = true;
            this.Tests.Location = new System.Drawing.Point(242, 32);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(209, 433);
            this.Tests.TabIndex = 5;
            this.Tests.DoubleClick += new System.EventHandler(this.Tests_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patch to Tests";
            // 
            // FLdName1
            // 
            this.FLdName1.Location = new System.Drawing.Point(363, 6);
            this.FLdName1.Name = "FLdName1";
            this.FLdName1.Size = new System.Drawing.Size(267, 20);
            this.FLdName1.TabIndex = 7;
            this.FLdName1.Visible = false;
            // 
            // FLdButton1
            // 
            this.FLdButton1.Location = new System.Drawing.Point(341, 4);
            this.FLdButton1.Name = "FLdButton1";
            this.FLdButton1.Size = new System.Drawing.Size(34, 23);
            this.FLdButton1.TabIndex = 8;
            this.FLdButton1.Text = ". . .";
            this.FLdButton1.UseVisualStyleBackColor = false;
            this.FLdButton1.Click += new System.EventHandler(this.FLdButton1_Click);
            // 
            // Remove1
            // 
            this.Remove1.Location = new System.Drawing.Point(242, 471);
            this.Remove1.Name = "Remove1";
            this.Remove1.Size = new System.Drawing.Size(75, 23);
            this.Remove1.TabIndex = 9;
            this.Remove1.Text = "Remove";
            this.Remove1.UseVisualStyleBackColor = true;
            this.Remove1.Click += new System.EventHandler(this.Remove1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(141, 471);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // OnlineUsers
            // 
            this.OnlineUsers.FormattingEnabled = true;
            this.OnlineUsers.Location = new System.Drawing.Point(481, 32);
            this.OnlineUsers.Name = "OnlineUsers";
            this.OnlineUsers.Size = new System.Drawing.Size(123, 264);
            this.OnlineUsers.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Online Users";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 317);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 148);
            this.textBox1.TabIndex = 13;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OnlineUsers);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove1);
            this.Controls.Add(this.FLdButton1);
            this.Controls.Add(this.FLdName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tests);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.FLdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLdName);
            this.Controls.Add(this.Lessons);
            this.Name = "Server";
            this.Text = "Hello Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lessons;
        private System.Windows.Forms.TextBox FLdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FLdButton;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ListBox Tests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FLdName1;
        private System.Windows.Forms.Button FLdButton1;
        private System.Windows.Forms.Button Remove1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox OnlineUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

