using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class DeleteBooking : System.Web.UI.Page
{

    //var to store the primary key value of the record to be deleted
    Int32 bookRef;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        bookRef = Convert.ToInt32(Session["bookRef"]);
    }

    protected void btnBackToBookings_Click(object sender, EventArgs e)
    {
        //delete the record
        Delete();
        //directs back to the login page 
        Response.Redirect("DefaultBook.aspx");
    }

    void Delete()
    {
        ////function to delete the selected record


        //create a new instance of the Customer collection
        clsBookingCollection BookingList = new clsBookingCollection(User.Identity.Name);
        //find the record to delete
        BookingList.ThisBookings.Find(bookRef);
        //delete the record
        BookingList.Delete(); 
    }
}