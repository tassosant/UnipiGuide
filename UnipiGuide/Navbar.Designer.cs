namespace UnipiGuide
{
    partial class Navbar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.reviewsMenuItem,
            this.schoolsMenuItem,
            this.aboutMenuItem});
            
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(99, 20);
            this.homeMenuItem.Text = "Home";
            // 
            // reviewsMenuItem
            // 
            this.reviewsMenuItem.Name = "reviewsMenuItem";
            this.reviewsMenuItem.Size = new System.Drawing.Size(118, 20);
            this.reviewsMenuItem.Text = "Reviews";
            // 
            // schoolsMenuItem
            // 
            this.schoolsMenuItem.Name = "schoolsMenuItem";
            this.schoolsMenuItem.Size = new System.Drawing.Size(116, 20);
            this.schoolsMenuItem.Text = "Schools";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aboutMenuItem.Text = "About";
            // 
            // Navbar
            // 
            this.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
           
            this.Size = new System.Drawing.Size(200, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    }
}
