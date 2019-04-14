using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class DefaultCont : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //display their user name 
        lblUserInfo.Text = "The current user is " + User.Identity.Name;
        // test to see if the are an admin
        if (User.IsInRole("admin"))
        {
            //display the delete button 
            btnDeleteCont.Visible = true;
        }
        else
        {
            //hide the delete button 
            btnDeleteCont.Visible = false;
        }
        //clear any exisiting error messages 
        lblError.Text = "";
        // if this is the first page has been displayed 
        if (IsPostBack == false)
        {

            // populate the list and display the number of records found
            //lblError.Text = DisplayContactUs("") + " records in the database";
            DisplayContactUs();
        }


        if (IsPostBack == false)
        {
            //update the list box
            DisplayContactUs();

        }
    }

    void DisplayContactUs()
    {
        //create an instancew of the Customer Collection
        clsContactUsCollection Contact = new clsContactUsCollection();
        // set the data source to the list of countries in the collection
        lstCont.DataSource = Contact.ContactList;
        // set the name of the primary key
        lstCont.DataValueField = "ContactId";
        // set the data field to display
        lstCont.DataTextField = "AllDetails";
        //bind the data to the list 
        lstCont.DataBind();

    }

    void FilterEmail(string Email)
    {
        //create an instance of the booking collection
        clsContactUsCollection Contact = new clsContactUsCollection();
        Contact.FilterbyEmail(Email);
        //set the data source to the list of bookings in the collection
        lstCont.DataSource = Contact.ContactList;
        //set the name of the primary key
        lstCont.DataValueField = "ContactId";
        //set the data field to display
        lstCont.DataTextField = "Email";
        //bind the data to the list
        lstCont.DataBind();
    }

    protected void btnDisplayAllCont_Click(object sender, EventArgs e)
    {
        DisplayContactUs();
    }

    protected void btnAddCont_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ContactId"] = -1;
        //redirect to the data entry page
        Response.Redirect("ContactUsPage.aspx");
    }

    protected void btnDeleteCont_Click(object sender, EventArgs e)
    {

        //var to store the primary key value of the record to be deleted
        Int32 ContactId;
        //if a record has been selected from the list
        if (lstCont.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ContactId = Convert.ToInt32(lstCont.SelectedValue);
            //store the data in the session object
            Session["ContactId"] = ContactId;
            //redirect to the delete page
            Response.Redirect("DeleteContactUs.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnFilterEmailCont_Click(object sender, EventArgs e)
    {
        FilterEmail(txtFilter.Text);
    }

    protected void btnEditCont_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ContactId;
        //if a record has been selected from the list
        if (lstCont.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ContactId = Convert.ToInt32(lstCont.SelectedValue);
            //store the data in the session object
            Session["ContactId"] = ContactId;
            //redirect to the edit page
            Response.Redirect("ContactUsPage.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}
