using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnipiGuide.Controllers;
using UnipiGuide.Models;

namespace UnipiGuide
{
    public partial class ReviewForm : Form
    {
        MockDB db; //will change in future, pass by reference instead of instantiation in this class's constructor
        public ReviewForm()
        {
            InitializeComponent();
            //pass by reference thd db
            DisplayRows();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitReviewButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayRows()
        {
            foreach(User user in MockDB.Users)
            {
                CreateRow(user);
            }
        }

        private void CreateRow(User user)
        {
            DataGridViewRow row = new DataGridViewRow();
            this.dataGridView1.Rows.Add(
                new object[]
                    {
                        user.UserName,
                        user.Review.Stars,
                        user.Review.Comment,
                    }
                );
            
            /*row.Cells["User"].Value = user.UserName;
            row.Cells["Stars"].Value = user.Review.Stars;
            row.Cells["Comment"].Value = user.Review.Comment;*/
            //Debug.WriteLine(this.dataGridView1.Columns[0].Name);
        }

        
    }
}
