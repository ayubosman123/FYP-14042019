using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class DefaultReview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //display their user name 
        lblUserInfo.Text = "The current user is " + User.Identity.Name;
        // test to see if the are an admin
        if (User.IsInRole("admin"))
        {
            //display the delete button 
            btnDeleteReview.Visible = true;
        }
        else
        {
            //hide the delete button 
            btnDeleteReview.Visible = false;
        }
        //clear any exisiting error messages 
        lblError.Text = "";
        // if this is the first page has been displayed 
        if (IsPostBack == false)
        {
            //sort this out later
            // populate the list and display the number of records found
            //lblError.Text = DisplayReviews()  " records in the database";
            DisplayReviews();

        }

            
        if (IsPostBack == false)
        {
            //update the list box
            DisplayReviews();

        }
    }

    void DisplayReviews()
    {
        //create an instancew of the Customer Collection
        clsReviewsCollection Review = new clsReviewsCollection(User.Identity.Name);
        // set the data source to the list of countries in the collection
        lstReviews.DataSource = Review.ReviewList;
        // set the name of the primary key
        lstReviews.DataValueField = "ReviewId";
        // set the data field to display
        lstReviews.DataTextField = "AllDetails";
        //bind the data to the list 
        lstReviews.DataBind();

    }

    void FilterEmail(string Email)
    {
        //create an instance of the booking collection
        clsReviewsCollection Review = new clsReviewsCollection();
        Review.FilterbyEmail(Email);
        //set the data source to the list of bookings in the collection
        lstReviews.DataSource = Review.ReviewList;
        //set the name of the primary key
        lstReviews.DataValueField = "ReviewId";
        //set the data field to display
        lstReviews.DataTextField = "Email";
        //bind the data to the list
        lstReviews.DataBind();
    }
    protected void btnDisplayAllReviews_Click(object sender, EventArgs e)
    {
        DisplayReviews();
    }

    protected void btnAddReview_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ReviewId"] = -1;
        //redirect to the data entry page
        Response.Redirect("ReviewPage.aspx");
    }

    protected void btnDeleteReview_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Id;
        //if a record has been selected from the list
        if (lstReviews.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Id = Convert.ToInt32(lstReviews.SelectedValue);
            //store the data in the session object
            Session["Id"] = Id;
            //redirect to the delete page
            Response.Redirect("DeleteReview.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = " You Must select a record to delete from the list";
        }

    }



    protected void btnFilterViaEmail_Click(object sender, EventArgs e)
    {
        FilterEmail(txtFilter.Text);
    }

    protected void btnEditReview_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ReviewId;
        //if a record has been selected from the list
        if (lstReviews.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ReviewId = Convert.ToInt32(lstReviews.SelectedValue);
            //store the data in the session object
            Session["ReviewId"] = ReviewId;
            //redirect to the edit page
            Response.Redirect("ReviewPage.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}

