using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class ReviewPage : System.Web.UI.Page
{
    Int32 ReviewId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the pk of the booking to be processed
        ReviewId = Convert.ToInt32(Session["ReviewId"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (ReviewId != -1)
            {
                //display the current data for the record
                DisplayReviews();
            }
        }
    }

    protected void btnBackToReviewPanel_Click(object sender, EventArgs e)
    {
        //redirect to the delete page
        Response.Redirect("DefaultReview.aspx");
    }

    protected void btnEnterReview_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
        if (ReviewId == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for Adding records
    void Add()
    {
        //create an instance of the booking list
        clsReviewsCollection Review = new clsReviewsCollection(User.Identity.Name);
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Review.ThisReview.Valid(txtEmail.Text, txtExp.Text, txtImproveexp.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            //Customer.ThisCustomer.Find(Id);
            //get the data entered by the user
            Review.ThisReview.Email = Convert.ToString(txtEmail.Text);
            Review.ThisReview.Exp = Convert.ToString(txtExp.Text);
            Review.ThisReview.Improveexp = Convert.ToString(txtImproveexp.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Review.Add();
            //all done so redirect back to the main page
            // Response.Redirect("AdminHomepage.aspx"); page does not exist
            lblError.Text = "add";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    void Update()
    {
        //create an instance of the booking list
        clsReviewsCollection Review = new clsReviewsCollection(User.Identity.Name);
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Review.ThisReview.Valid(txtEmail.Text, txtExp.Text, txtImproveexp.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Review.ThisReview.Find(ReviewId);
            //get the data entered by the user
            Review.ThisReview.Email = Convert.ToString(txtEmail.Text);
            Review.ThisReview.Exp = Convert.ToString(txtExp.Text);
            Review.ThisReview.Improveexp = Convert.ToString(txtImproveexp.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Review.Update();
            //all done so redirect back to the main page
            //  Response.Redirect("AdminHomepage.aspx");
            lblError.Text = "update";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayReviews()
    {
        //create an instance of the booking list
        clsReviewsCollection Review = new clsReviewsCollection(User.Identity.Name);
        //find the record to update
        Review.ThisReview.Find(ReviewId);
        //display the data for this record
        txtEmail.Text = Review.ThisReview.Email;
        txtExp.Text = Review.ThisReview.Exp;
        txtImproveexp.Text = Review.ThisReview.Improveexp;
    }

}


