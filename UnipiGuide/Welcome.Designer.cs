namespace UnipiGuide
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameTextBox = new System.Windows.Forms.RichTextBox();
            this.PasswordTextBox = new System.Windows.Forms.RichTextBox();
            this.GuestButton = new ePOSOne.btnProduct.Button_WOC();
            this.LoginButton = new ePOSOne.btnProduct.Button_WOC();
            this.ErrorLoginMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(498, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnipiGuide.Properties.Resources.logopapei3;
            this.pictureBox1.Location = new System.Drawing.Point(504, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(669, 213);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(305, 46);
            this.UsernameTextBox.TabIndex = 4;
            this.UsernameTextBox.Text = "";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(669, 298);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(305, 46);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.Text = "";
            // 
            // GuestButton
            // 
            this.GuestButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.GuestButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.GuestButton.FlatAppearance.BorderSize = 0;
            this.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestButton.Location = new System.Drawing.Point(504, 613);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.GuestButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.GuestButton.OnHoverTextColor = System.Drawing.Color.LightGreen;
            this.GuestButton.Size = new System.Drawing.Size(295, 85);
            this.GuestButton.TabIndex = 6;
            this.GuestButton.Text = "Continue as Guest";
            this.GuestButton.TextColor = System.Drawing.Color.White;
            this.GuestButton.UseVisualStyleBackColor = true;
            this.GuestButton.Click += new System.EventHandler(this.guest_button_WOC2_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BorderColor = System.Drawing.Color.Silver;
            this.LoginButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(504, 401);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.LoginButton.OnHoverButtonColor = System.Drawing.Color.LightGreen;
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.LoginButton.Size = new System.Drawing.Size(159, 60);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.login_button_WOC1_Click);
            // 
            // ErrorLoginMessageLabel
            // 
            this.ErrorLoginMessageLabel.AutoSize = true;
            this.ErrorLoginMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginMessageLabel.Location = new System.Drawing.Point(669, 360);
            this.ErrorLoginMessageLabel.Name = "ErrorLoginMessageLabel";
            this.ErrorLoginMessageLabel.Size = new System.Drawing.Size(0, 25);
            this.ErrorLoginMessageLabel.TabIndex = 7;
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1563, 756);
            this.Controls.Add(this.ErrorLoginMessageLabel);
            this.Controls.Add(this.GuestButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC LoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox UsernameTextBox;
        private System.Windows.Forms.RichTextBox PasswordTextBox;
        private ePOSOne.btnProduct.Button_WOC GuestButton;
        private System.Windows.Forms.Label ErrorLoginMessageLabel;
    }
}

