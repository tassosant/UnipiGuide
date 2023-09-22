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
        int rating;
        ArrayList whiteStars;
        ArrayList yellowStars;
        public ReviewForm()
        {
            InitializeComponent();
            this.MainMenuStrip.AllowItemReorder = false;
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
            foreach (PictureBox pictureBox in this.yellowStars)
            {
                pictureBox.Click += new System.EventHandler(this.OnStarClick);
            }
            this.SuspendLayout();
            this.FormClosing += Form_Closing;
            this.ResumeLayout(false);
        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            throw new NotImplementedException();
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

        private void ShowIcons(ArrayList sourceArrayList, int firstIndex, int lastIndex) { 

            foreach(PictureBox pictureBox in sourceArrayList) {
                int index = sourceArrayList.IndexOf(pictureBox)+1;
                if (index <= lastIndex && index>=firstIndex)
                {
                    pictureBox.Show();
                }                
            }

        }

        private void HideIcons(ArrayList sourceArrayList, int firstIndex, int lastIndex)
        {

            foreach (PictureBox pictureBox in sourceArrayList)
            {
                int index = sourceArrayList.IndexOf(pictureBox) + 1;
                if (index <= lastIndex && index>=firstIndex)
                {
                    pictureBox.Hide();
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
            //foreach(PictureBox pictureBox in this.whiteStars)
            //{
            //    if (pictureBox.Equals(sender))
            //    {
            //        String selectedTag = pictureBox.Tag.ToString();
            //        //check if tag contains white or yellow
            //        //
            //        Debug.WriteLine(selectedTag);
            //        return;
            //    }
            //}

            PictureBox pictureBox = sender as PictureBox;
            String tag = pictureBox.Tag.ToString();
            int num = Int32.Parse(tag[tag.Length - 1].ToString());
            this.rating = num;
            //if (tag.Contains("white"))
            //{
            //    HideIcons(this.whiteStars, "white1", "white"+num.ToString());

            //    string yellowTagStart = "yellow1";
            //    string yellowTagEnd = tag;                
            //    ShowIcons(this.yellowStars, yellowTagStart, yellowTagEnd);
            //    if (num != 5)
            //    {
            //        num++;
            //    }
            //    yellowTagStart = "yellow" + num.ToString();
            //    yellowTagEnd = "yellow5";
            //    HideIcons(this.yellowStars, yellowTagStart, yellowTagEnd);
            //}
            //if (tag.Contains("yellow"))
            //{
            //    string yellowTagStart = "yellow5";
            //    if (num != 5)
            //    {
            //        yellowTagStart = "yellow" + (num+1).ToString();
            //    }
            //    string yellowTagEnd = "yellow5";
            //    HideIcons(this.yellowStars, yellowTagStart, yellowTagEnd);
            //    string whiteTagStart = "white"+(num+1).ToString();
            //    string whiteTagEnd = "white5";
            //    ShowIcons(this.whiteStars, whiteTagStart, whiteTagEnd);
            //}
            if (tag.Contains("white"))
            {
                //show yellow from 1 to selected integer
                ShowIcons(this.yellowStars, 1, num);
                HideIcons(this.whiteStars, 1, num);
                HideIcons(this.yellowStars, num+1, this.yellowStars.Count);                                                                              
            }
            if (tag.Contains("yellow"))
            {
                
                ShowIcons(this.whiteStars, num+1, this.whiteStars.Count);
                HideIcons(this.yellowStars, num+1, this.yellowStars.Count);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitReviewButton_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            review.Stars = this.rating; //count the clicked icons
            review.ReviewId = MockDB.Reviews.Count + 1;
            review.Comment = this.commentRichTextBox.Text;
            if (MockDB.SelectedUser == null)
            {
               User guest = new User();
               MockDB.CreateGuest(guest);
               MockDB.SelectedUser = guest;
            }
            Review previousReview = MockDB.SelectedUser.Review;
            MockDB.Reviews.Remove(previousReview);
            MockDB.SelectedUser.Review = review;
            MockDB.Reviews.Add(review);
            
            DisplayRows();

        }
        
        private void DisplayRows()
        {
            this.reviewsDataGridView.Rows.Clear();
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
                        user.Review.Stars + "/5",
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

        private void ReviewForm_Load(object sender, EventArgs e)
        {

        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                
                Application.Exit();
            }
        }

    }
}
