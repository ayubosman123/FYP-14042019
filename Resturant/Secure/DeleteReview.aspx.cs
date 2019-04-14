using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class DeleteReview : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ReviewId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        ReviewId = Convert.ToInt32(Session["ReviewId"]);
    }

    protected void btnBackToReviewPage_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteReviews();
        //directs back to the login page 
        Response.Redirect("DefaultReview.aspx");
    }
    void DeleteReviews()
    {
        ////function to delete the selected record


        //create a new instance of the Customer collection
        clsReviewsCollection ReviewList = new clsReviewsCollection(User.Identity.Name);
        //find the record to delete
        ReviewList.ThisReview.Find(ReviewId);
        //delete the record
        ReviewList.Delete();
    }
}
