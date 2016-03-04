namespace ProjectServer
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
            this.button1 = new System.Windows.Forms.Button();
            this.Logger = new System.Windows.Forms.TextBox();
            this.ListenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Logger
            // 
            this.Logger.Location = new System.Drawing.Point(0, 308);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.Size = new System.Drawing.Size(278, 126);
            this.Logger.TabIndex = 1;
            // 
            // ListenTimer
            // 
            this.ListenTimer.Interval = 1000;
            this.ListenTimer.Tick += new System.EventHandler(this.ListenTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 434);
            this.Controls.Add(this.Logger);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ServerProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Logger;
        public System.Windows.Forms.Timer ListenTimer;
    }
}

