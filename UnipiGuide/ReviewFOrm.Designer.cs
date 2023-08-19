namespace UnipiGuide
{
    partial class ReviewForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StarsLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitReviewButton = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnipiGuide.Properties.Resources.logopapei3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StarsLabel
            // 
            this.StarsLabel.AutoSize = true;
            this.StarsLabel.ForeColor = System.Drawing.Color.Snow;
            this.StarsLabel.Location = new System.Drawing.Point(55, 179);
            this.StarsLabel.Name = "StarsLabel";
            this.StarsLabel.Size = new System.Drawing.Size(62, 25);
            this.StarsLabel.TabIndex = 7;
            this.StarsLabel.Text = "Stars";
            this.StarsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CommentLabel.Location = new System.Drawing.Point(55, 246);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(103, 25);
            this.CommentLabel.TabIndex = 8;
            this.CommentLabel.Text = "Comment";
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(60, 316);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(667, 245);
            this.commentRichTextBox.TabIndex = 9;
            this.commentRichTextBox.Text = "";
            // 
            // SubmitReviewButton
            // 
            this.SubmitReviewButton.BorderColor = System.Drawing.Color.Silver;
            this.SubmitReviewButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.SubmitReviewButton.FlatAppearance.BorderSize = 0;
            this.SubmitReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitReviewButton.Location = new System.Drawing.Point(60, 593);
            this.SubmitReviewButton.Name = "SubmitReviewButton";
            this.SubmitReviewButton.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.SubmitReviewButton.OnHoverButtonColor = System.Drawing.Color.LightGreen;
            this.SubmitReviewButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.SubmitReviewButton.Size = new System.Drawing.Size(159, 60);
            this.SubmitReviewButton.TabIndex = 11;
            this.SubmitReviewButton.Text = "Submit";
            this.SubmitReviewButton.TextColor = System.Drawing.Color.White;
            this.SubmitReviewButton.UseVisualStyleBackColor = true;
            this.SubmitReviewButton.Click += new System.EventHandler(this.SubmitReviwButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1563, 756);
            this.Controls.Add(this.SubmitReviewButton);
            this.Controls.Add(this.commentRichTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.StarsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviews";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StarsLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private ePOSOne.btnProduct.Button_WOC SubmitReviewButton;
    }
}