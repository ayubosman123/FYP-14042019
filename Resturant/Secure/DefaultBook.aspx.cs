using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class DefaultBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //display their user name 
        lblUserInfo.Text = "The current user is " + User.Identity.Name;
        // test to see if the are an admin
        if(User.IsInRole("admin"))
        {
            //display the delete button 
            btnDeleteBooking.Visible = true;
        }
        else
        {
            //hide the delete button 
            btnDeleteBooking.Visible = false;
        }
        //clear any exisiting error messages 
        lblError.Text = "";
        // if this is the first page has been displayed 
        if (IsPostBack == false)
        { 
            // populate the list and display the number of records found
            //lblError.Text = DisplayBookings("") + " records in the database";
            DisplayBookings();

        }

           


        if (IsPostBack == false)
        {
            //update the list box
            DisplayBookings();

        }
    }

    void DisplayBookings()
    {
        //create an instancew of the Customer Collection
        clsBookingCollection Booking = new clsBookingCollection();
        // set the data source to the list of countries in the collection
        lstBooking.DataSource = Booking.BookingsList;
        // set the name of the primary key
        lstBooking.DataValueField = "bookRef";
        // set the data field to display
        lstBooking.DataTextField = "AllDetails";
        //bind the data to the list 
        lstBooking.DataBind();

    }

    void Filteremail(string useremail)
    {
        //create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        Booking.Filterbyemail(useremail);
        //set the data source to the list of bookings in the collection
        lstBooking.DataSource = Booking.BookingsList;
        //set the name of the primary key
        lstBooking.DataValueField = "bookRef";
        //set the data field to display
        lstBooking.DataTextField = "useremail";
        //bind the data to the list
        lstBooking.DataBind();
    }

    protected void btnDisplayAllBookings_Click(object sender, EventArgs e)
    {
        DisplayBookings();
    }

    protected void btnAddBooking_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["bookRef"] = -1;
        //redirect to the data entry page
        Response.Redirect("BookingPage.aspx");
    }

    protected void btnDeleteBooking_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 bookRef;
        //if a record has been selected from the list
        if (lstBooking.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            bookRef = Convert.ToInt32(lstBooking.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = bookRef;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }



    protected void btnUserFilter_Click(object sender, EventArgs e)
    {
        Filteremail(txtFilter.Text);
    }

    protected void btnEditBooking_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookRef;
        //if a record has been selected from the list
        if (lstBooking.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            BookRef = Convert.ToInt32(lstBooking.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = BookRef;
            //redirect to the edit page
            Response.Redirect("BookingPage.aspx");
        }
        else//if no record has been selected
        {
            //display an error
           lblError.Text = "Please select a record to edit from the list";
        }
    }


}

