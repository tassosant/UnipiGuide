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
            this.UsernameReviewLabel = new System.Windows.Forms.Label();
            this.StarsReviewLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.SubmitReviewButton.Click += new System.EventHandler(this.SubmitReviewButton_Click);
            // 
            // UsernameReviewLabel
            // 
            this.UsernameReviewLabel.AutoSize = true;
            this.UsernameReviewLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameReviewLabel.Location = new System.Drawing.Point(910, 179);
            this.UsernameReviewLabel.Name = "UsernameReviewLabel";
            this.UsernameReviewLabel.Size = new System.Drawing.Size(57, 25);
            this.UsernameReviewLabel.TabIndex = 12;
            this.UsernameReviewLabel.Text = "User";
            // 
            // StarsReviewLabel
            // 
            this.StarsReviewLabel.AutoSize = true;
            this.StarsReviewLabel.ForeColor = System.Drawing.Color.White;
            this.StarsReviewLabel.Location = new System.Drawing.Point(910, 246);
            this.StarsReviewLabel.Name = "StarsReviewLabel";
            this.StarsReviewLabel.Size = new System.Drawing.Size(62, 25);
            this.StarsReviewLabel.TabIndex = 13;
            this.StarsReviewLabel.Text = "Stars";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Stars,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(853, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(528, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 10;
            this.User.Name = "User";
            this.User.Width = 200;
            // 
            // Stars
            // 
            this.Stars.HeaderText = "Stars";
            this.Stars.MinimumWidth = 10;
            this.Stars.Name = "Stars";
            this.Stars.Width = 200;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 10;
            this.Comment.Name = "Comment";
            this.Comment.Width = 200;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1563, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UsernameReviewLabel);
            this.Controls.Add(this.StarsReviewLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StarsLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private ePOSOne.btnProduct.Button_WOC SubmitReviewButton;
        private System.Windows.Forms.Label UsernameReviewLabel;
        private System.Windows.Forms.Label StarsReviewLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}