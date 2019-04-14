using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class BookingPage : System.Web.UI.Page
{
    Int32 bookRef;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the pk of the booking to be processed
        bookRef = Convert.ToInt32(Session["bookRef"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (bookRef != -1)
            {
                //display the current data for the record
                DisplayBooking();
            }
        }
    }

    protected void btnBacktoBookingPanel_Click(object sender, EventArgs e)
    {
        //redirect to the delete page
        Response.Redirect("DefaultBook.aspx");
    }

    protected void btnSubmitBooking_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
        if (bookRef == -1)
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
        clsBookingCollection Bookings = new clsBookingCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Bookings.ThisBookings.Valid(txtuseremail.Text, txtDateBooked.Text, txtTimeBooked.Text, txtGuestsBooked.Text, txtDiningBooked.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            //Customer.ThisCustomer.Find(Id);
            //get the data entered by the user
            Bookings.ThisBookings.useremail = Convert.ToString(txtuseremail.Text);
            Bookings.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBooked.Text);
            Bookings.ThisBookings.TimeBooked = Convert.ToString(txtTimeBooked.Text);
            Bookings.ThisBookings.GuestsBooked = Convert.ToString(txtGuestsBooked.Text);
            Bookings.ThisBookings.DiningBooked = Convert.ToString(txtDiningBooked.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Bookings.Add();
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
        clsBookingCollection Bookings = new clsBookingCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Bookings.ThisBookings.Valid(txtuseremail.Text, txtDateBooked.Text, txtTimeBooked.Text, txtGuestsBooked.Text, txtDiningBooked.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Bookings.ThisBookings.Find(bookRef);
            //get the data entered by the user
            Bookings.ThisBookings.useremail = Convert.ToString(txtuseremail.Text);
            Bookings.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBooked.Text);
            Bookings.ThisBookings.TimeBooked = Convert.ToString(txtTimeBooked.Text);
            Bookings.ThisBookings.GuestsBooked = Convert.ToString(txtGuestsBooked.Text);
            Bookings.ThisBookings.DiningBooked = Convert.ToString(txtDiningBooked.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Bookings.Update();
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

    void DisplayBooking()
    {
        //create an instance of the booking list
        clsBookingCollection Bookings = new clsBookingCollection();
        //find the record to update
        Bookings.ThisBookings.Find(bookRef);
        //display the data for this record
        txtuseremail.Text = Bookings.ThisBookings.useremail;
        txtDateBooked.Text = Bookings.ThisBookings.DateBooked.ToString("dd/MM/yyyy");
        txtTimeBooked.Text = Bookings.ThisBookings.TimeBooked;
        txtGuestsBooked.Text = Bookings.ThisBookings.GuestsBooked;
        txtDiningBooked.Text = Bookings.ThisBookings.DiningBooked;
    }

}

