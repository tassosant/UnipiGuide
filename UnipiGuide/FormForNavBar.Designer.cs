namespace UnipiGuide
{
    partial class FormForNavBar
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingElseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.schoolsToolStripMenuItem,
            this.eclassToolStripMenuItem,
            this.somethingElseToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(99, 38);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(116, 38);
            this.schoolsToolStripMenuItem.Text = "Schools";
            this.schoolsToolStripMenuItem.Click += new System.EventHandler(this.SchoolsToolStripMenuItem_Click);
            // 
            // eclassToolStripMenuItem
            // 
            this.eclassToolStripMenuItem.Name = "eclassToolStripMenuItem";
            this.eclassToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.eclassToolStripMenuItem.Text = "Eclass";
            // 
            // somethingElseToolStripMenuItem
            // 
            this.somethingElseToolStripMenuItem.Name = "somethingElseToolStripMenuItem";
            this.somethingElseToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
            this.somethingElseToolStripMenuItem.Text = "Reviews";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormForNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormForNavBar";
            this.Text = "FormForNavBar";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eclassToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somethingElseToolStripMenuItem;
    }
}