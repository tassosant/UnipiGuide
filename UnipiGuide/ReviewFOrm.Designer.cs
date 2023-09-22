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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StarsLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reviewsDataGridView = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.yellowStarPictureBox = new System.Windows.Forms.PictureBox();
            this.whiteStarPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.whiteStarPictureBox2 = new System.Windows.Forms.PictureBox();
            this.yellowStarPictureBox2 = new System.Windows.Forms.PictureBox();
            this.whiteStarPictureBox3 = new System.Windows.Forms.PictureBox();
            this.whiteStarPictureBox4 = new System.Windows.Forms.PictureBox();
            this.whiteStarPictureBox5 = new System.Windows.Forms.PictureBox();
            this.yellowStarPictureBox3 = new System.Windows.Forms.PictureBox();
            this.yellowStarPictureBox4 = new System.Windows.Forms.PictureBox();
            this.yellowStarPictureBox5 = new System.Windows.Forms.PictureBox();
            this.printButton = new ePOSOne.btnProduct.Button_WOC();
            this.SubmitReviewButton = new ePOSOne.btnProduct.Button_WOC();
            this.navbar1 = new UnipiGuide.Navbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // StarsLabel
            // 
            this.StarsLabel.AutoSize = true;
            this.StarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsLabel.ForeColor = System.Drawing.Color.Snow;
            this.StarsLabel.Location = new System.Drawing.Point(68, 268);
            this.StarsLabel.Name = "StarsLabel";
            this.StarsLabel.Size = new System.Drawing.Size(92, 37);
            this.StarsLabel.TabIndex = 7;
            this.StarsLabel.Text = "Stars";
            this.StarsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CommentLabel.Location = new System.Drawing.Point(68, 360);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(156, 37);
            this.CommentLabel.TabIndex = 8;
            this.CommentLabel.Text = "Comment";
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(73, 400);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(667, 245);
            this.commentRichTextBox.TabIndex = 9;
            this.commentRichTextBox.Text = "";
            // 
            // reviewsDataGridView
            // 
            this.reviewsDataGridView.AllowUserToAddRows = false;
            this.reviewsDataGridView.AllowUserToDeleteRows = false;
            this.reviewsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reviewsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.reviewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Stars,
            this.Comment});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reviewsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.reviewsDataGridView.GridColor = System.Drawing.SystemColors.HighlightText;
            this.reviewsDataGridView.Location = new System.Drawing.Point(772, 138);
            this.reviewsDataGridView.Name = "reviewsDataGridView";
            this.reviewsDataGridView.ReadOnly = true;
            this.reviewsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.reviewsDataGridView.RowHeadersVisible = false;
            this.reviewsDataGridView.RowHeadersWidth = 82;
            this.reviewsDataGridView.RowTemplate.Height = 33;
            this.reviewsDataGridView.Size = new System.Drawing.Size(743, 507);
            this.reviewsDataGridView.TabIndex = 16;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 10;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 122;
            // 
            // Stars
            // 
            this.Stars.DataPropertyName = "Stars";
            this.Stars.HeaderText = "Stars";
            this.Stars.MinimumWidth = 10;
            this.Stars.Name = "Stars";
            this.Stars.ReadOnly = true;
            this.Stars.Width = 122;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 10;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 200;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // yellowStarPictureBox
            // 
            this.yellowStarPictureBox.Image = global::UnipiGuide.Properties.Resources.yellow_small_40;
            this.yellowStarPictureBox.Location = new System.Drawing.Point(177, 234);
            this.yellowStarPictureBox.Name = "yellowStarPictureBox";
            this.yellowStarPictureBox.Size = new System.Drawing.Size(87, 93);
            this.yellowStarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowStarPictureBox.TabIndex = 19;
            this.yellowStarPictureBox.TabStop = false;
            this.yellowStarPictureBox.Tag = "yellow1";
            // 
            // whiteStarPictureBox
            // 
            this.whiteStarPictureBox.Image = global::UnipiGuide.Properties.Resources.white_star_smaller__2_;
            this.whiteStarPictureBox.Location = new System.Drawing.Point(177, 234);
            this.whiteStarPictureBox.Name = "whiteStarPictureBox";
            this.whiteStarPictureBox.Size = new System.Drawing.Size(87, 93);
            this.whiteStarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiteStarPictureBox.TabIndex = 18;
            this.whiteStarPictureBox.TabStop = false;
            this.whiteStarPictureBox.Tag = "white1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnipiGuide.Properties.Resources.logopapei3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // whiteStarPictureBox2
            // 
            this.whiteStarPictureBox2.Image = global::UnipiGuide.Properties.Resources.white_star_smaller__2_;
            this.whiteStarPictureBox2.Location = new System.Drawing.Point(270, 234);
            this.whiteStarPictureBox2.Name = "whiteStarPictureBox2";
            this.whiteStarPictureBox2.Size = new System.Drawing.Size(87, 93);
            this.whiteStarPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiteStarPictureBox2.TabIndex = 20;
            this.whiteStarPictureBox2.TabStop = false;
            this.whiteStarPictureBox2.Tag = "white2";
            // 
            // yellowStarPictureBox2
            // 
            this.yellowStarPictureBox2.Image = global::UnipiGuide.Properties.Resources.yellow_small_40;
            this.yellowStarPictureBox2.Location = new System.Drawing.Point(270, 234);
            this.yellowStarPictureBox2.Name = "yellowStarPictureBox2";
            this.yellowStarPictureBox2.Size = new System.Drawing.Size(87, 93);
            this.yellowStarPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowStarPictureBox2.TabIndex = 21;
            this.yellowStarPictureBox2.TabStop = false;
            this.yellowStarPictureBox2.Tag = "yellow2";
            // 
            // whiteStarPictureBox3
            // 
            this.whiteStarPictureBox3.Image = global::UnipiGuide.Properties.Resources.white_star_smaller__2_;
            this.whiteStarPictureBox3.Location = new System.Drawing.Point(363, 234);
            this.whiteStarPictureBox3.Name = "whiteStarPictureBox3";
            this.whiteStarPictureBox3.Size = new System.Drawing.Size(87, 93);
            this.whiteStarPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiteStarPictureBox3.TabIndex = 22;
            this.whiteStarPictureBox3.TabStop = false;
            this.whiteStarPictureBox3.Tag = "white3";
            // 
            // whiteStarPictureBox4
            // 
            this.whiteStarPictureBox4.Image = global::UnipiGuide.Properties.Resources.white_star_smaller__2_;
            this.whiteStarPictureBox4.Location = new System.Drawing.Point(456, 234);
            this.whiteStarPictureBox4.Name = "whiteStarPictureBox4";
            this.whiteStarPictureBox4.Size = new System.Drawing.Size(87, 93);
            this.whiteStarPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiteStarPictureBox4.TabIndex = 23;
            this.whiteStarPictureBox4.TabStop = false;
            this.whiteStarPictureBox4.Tag = "white4";
            // 
            // whiteStarPictureBox5
            // 
            this.whiteStarPictureBox5.Image = global::UnipiGuide.Properties.Resources.white_star_smaller__2_;
            this.whiteStarPictureBox5.Location = new System.Drawing.Point(549, 234);
            this.whiteStarPictureBox5.Name = "whiteStarPictureBox5";
            this.whiteStarPictureBox5.Size = new System.Drawing.Size(87, 93);
            this.whiteStarPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiteStarPictureBox5.TabIndex = 24;
            this.whiteStarPictureBox5.TabStop = false;
            this.whiteStarPictureBox5.Tag = "white5";
            // 
            // yellowStarPictureBox3
            // 
            this.yellowStarPictureBox3.Image = global::UnipiGuide.Properties.Resources.yellow_small_40;
            this.yellowStarPictureBox3.Location = new System.Drawing.Point(363, 234);
            this.yellowStarPictureBox3.Name = "yellowStarPictureBox3";
            this.yellowStarPictureBox3.Size = new System.Drawing.Size(87, 93);
            this.yellowStarPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowStarPictureBox3.TabIndex = 25;
            this.yellowStarPictureBox3.TabStop = false;
            this.yellowStarPictureBox3.Tag = "yellow3";
            // 
            // yellowStarPictureBox4
            // 
            this.yellowStarPictureBox4.Image = global::UnipiGuide.Properties.Resources.yellow_small_40;
            this.yellowStarPictureBox4.Location = new System.Drawing.Point(456, 234);
            this.yellowStarPictureBox4.Name = "yellowStarPictureBox4";
            this.yellowStarPictureBox4.Size = new System.Drawing.Size(87, 93);
            this.yellowStarPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowStarPictureBox4.TabIndex = 26;
            this.yellowStarPictureBox4.TabStop = false;
            this.yellowStarPictureBox4.Tag = "yellow4";
            // 
            // yellowStarPictureBox5
            // 
            this.yellowStarPictureBox5.Image = global::UnipiGuide.Properties.Resources.yellow_small_40;
            this.yellowStarPictureBox5.Location = new System.Drawing.Point(549, 234);
            this.yellowStarPictureBox5.Name = "yellowStarPictureBox5";
            this.yellowStarPictureBox5.Size = new System.Drawing.Size(87, 93);
            this.yellowStarPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowStarPictureBox5.TabIndex = 27;
            this.yellowStarPictureBox5.TabStop = false;
            this.yellowStarPictureBox5.Tag = "yellow5";
            // 
            // printButton
            // 
            this.printButton.BorderColor = System.Drawing.Color.Silver;
            this.printButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(772, 667);
            this.printButton.Margin = new System.Windows.Forms.Padding(4);
            this.printButton.Name = "printButton";
            this.printButton.OnHoverBorderColor = System.Drawing.Color.LightGreen;
            this.printButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.printButton.OnHoverTextColor = System.Drawing.Color.LightGreen;
            this.printButton.Size = new System.Drawing.Size(191, 70);
            this.printButton.TabIndex = 17;
            this.printButton.Text = "print";
            this.printButton.TextColor = System.Drawing.Color.White;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SubmitReviewButton
            // 
            this.SubmitReviewButton.BorderColor = System.Drawing.Color.Silver;
            this.SubmitReviewButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.SubmitReviewButton.FlatAppearance.BorderSize = 0;
            this.SubmitReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitReviewButton.Location = new System.Drawing.Point(73, 667);
            this.SubmitReviewButton.Name = "SubmitReviewButton";
            this.SubmitReviewButton.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.SubmitReviewButton.OnHoverButtonColor = System.Drawing.Color.LightGreen;
            this.SubmitReviewButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.SubmitReviewButton.Size = new System.Drawing.Size(191, 70);
            this.SubmitReviewButton.TabIndex = 11;
            this.SubmitReviewButton.Text = "Submit";
            this.SubmitReviewButton.TextColor = System.Drawing.Color.White;
            this.SubmitReviewButton.UseVisualStyleBackColor = true;
            this.SubmitReviewButton.Click += new System.EventHandler(this.SubmitReviewButton_Click);
            // 
            // navbar1
            // 
            this.navbar1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.navbar1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(1632, 40);
            this.navbar1.TabIndex = 28;
            this.navbar1.Text = "navbar1";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1632, 843);
            this.Controls.Add(this.whiteStarPictureBox5);
            this.Controls.Add(this.whiteStarPictureBox4);
            this.Controls.Add(this.whiteStarPictureBox3);
            this.Controls.Add(this.whiteStarPictureBox2);
            this.Controls.Add(this.whiteStarPictureBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.reviewsDataGridView);
            this.Controls.Add(this.SubmitReviewButton);
            this.Controls.Add(this.commentRichTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.StarsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yellowStarPictureBox5);
            this.Controls.Add(this.yellowStarPictureBox4);
            this.Controls.Add(this.yellowStarPictureBox3);
            this.Controls.Add(this.yellowStarPictureBox2);
            this.Controls.Add(this.yellowStarPictureBox);
            this.Controls.Add(this.navbar1);
            this.MainMenuStrip = this.navbar1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteStarPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStarPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StarsLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private ePOSOne.btnProduct.Button_WOC SubmitReviewButton;
        private System.Windows.Forms.DataGridView reviewsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private ePOSOne.btnProduct.Button_WOC printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox whiteStarPictureBox;
        private System.Windows.Forms.PictureBox yellowStarPictureBox;
        private System.Windows.Forms.PictureBox whiteStarPictureBox2;
        private System.Windows.Forms.PictureBox yellowStarPictureBox2;
        private System.Windows.Forms.PictureBox whiteStarPictureBox3;
        private System.Windows.Forms.PictureBox whiteStarPictureBox4;
        private System.Windows.Forms.PictureBox whiteStarPictureBox5;
        private System.Windows.Forms.PictureBox yellowStarPictureBox3;
        private System.Windows.Forms.PictureBox yellowStarPictureBox4;
        private System.Windows.Forms.PictureBox yellowStarPictureBox5;
        private Navbar navbar1;
    }
}