using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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

        ArrayList whiteStars;
        ArrayList yellowStars;
        public ReviewForm()
        {
            InitializeComponent();
            //pass by reference thd db
            DisplayRows();
            yellowStars = new ArrayList();
            whiteStars = new ArrayList();
            CollectStarPictureBoxes();
            AddMouseClicks();
        }

        private void CollectStarPictureBoxes()
        {
            
            this.yellowStars.Add(this.yellowStarPictureBox);
            this.yellowStars.Add(this.yellowStarPictureBox2);
            this.yellowStars.Add(this.yellowStarPictureBox3);
            this.yellowStars.Add(this.yellowStarPictureBox4);
            this.yellowStars.Add(this.yellowStarPictureBox5);
            this.whiteStars.Add(this.whiteStarPictureBox);
            this.whiteStars.Add(this.whiteStarPictureBox2);
            this.whiteStars.Add(this.whiteStarPictureBox3);
            this.whiteStars.Add(this.whiteStarPictureBox4);
            this.whiteStars.Add(this.whiteStarPictureBox5);
            
        }

        private void AddMouseClicks()
        {
            foreach(PictureBox pictureBox in this.whiteStars){
                pictureBox.Click += new System.EventHandler(this.OnStarClick);
            }
        }

        private void HideIcons(ArrayList sourceArrayList, String tagStart, String tagEnd)
        {
            foreach(PictureBox pictureBox in sourceArrayList)
            {
                String tag = pictureBox.Tag.ToString();
                if(
                    (FirstIsSmaller(tag, tagEnd) || tag.Equals(tagEnd)) &&
                    !FirstIsSmaller(tag, tagStart)
                    ){
                    pictureBox.Hide();
                }
                
            }
        }
        private void ShowIcons(ArrayList sourceArrayList, String tagStart, String tagEnd)
        {
            foreach(PictureBox pictureBox in sourceArrayList) { 
                String tag = pictureBox.Tag.ToString();
                if(FirstIsSmaller(tag, tagEnd) || tag.Equals(tagEnd) &&
                    !FirstIsSmaller(tag, tagStart)){
                    pictureBox.Show(); 
                }

            }
        }
        

        private bool FirstIsSmaller(String tag1, String tag2)
        {
            if (String.Compare(tag1, tag2) < 0)
            {
                return true;
            }
            return false;
        }



        private void OnStarClick(object sender, EventArgs e)
        {
            foreach(PictureBox pictureBox in this.whiteStars)
            {
                if (pictureBox.Equals(sender))
                {
                    Debug.WriteLine(pictureBox.Tag);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitReviewButton_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            review.Stars = 4; //count the clicked icon
            review.ReviewId = MockDB.Reviews.Count + 1;
            review.Comment = this.commentRichTextBox.Text;

            Review previousReview = MockDB.SelectedUser.Review;
            MockDB.Reviews.Remove(previousReview);
            
            MockDB.Reviews.Add(review);
            MockDB.SelectedUser.Review = review;
            

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
            this.reviewsDataGridView.Rows.Add(
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
            printDocument.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.reviewsDataGridView.ToString(), this.reviewsDataGridView.Font, Brushes.Black, 10, 25);
        }
    }
}
