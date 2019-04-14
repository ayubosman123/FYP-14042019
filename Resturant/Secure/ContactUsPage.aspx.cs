using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class ContactUsPage : System.Web.UI.Page
{
    Int32 ContactId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the pk of the booking to be processed
        ContactId = Convert.ToInt32(Session["ContactId"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (ContactId != -1)
            {
                //display the current data for the record
                DisplayContact();
            }
        }
    }

    protected void btnBackToContactUsPanel_Click(object sender, EventArgs e)
    {
        //redirect to the delete page
        Response.Redirect("DefaultContactUs.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
        if (ContactId == -1)
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
        clsContactUsCollection Contacts = new clsContactUsCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Contacts.ThisContact.Valid(txtEmail.Text, txtName.Text, txtMessage.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            //Customer.ThisCustomer.Find(Id);
            //get the data entered by the user
            Contacts.ThisContact.Email = Convert.ToString(txtEmail.Text);
            Contacts.ThisContact.Name = Convert.ToString(txtName.Text);
            Contacts.ThisContact.Message = Convert.ToString(txtMessage.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Contacts.Add();
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
        clsContactUsCollection Contacts = new clsContactUsCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Contacts.ThisContact.Valid(txtEmail.Text, txtName.Text, txtMessage.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Contacts.ThisContact.Find(ContactId);
            //get the data entered by the user
            Contacts.ThisContact.Email = Convert.ToString(txtEmail.Text);
            Contacts.ThisContact.Name = Convert.ToString(txtName.Text);
            Contacts.ThisContact.Message = Convert.ToString(txtMessage.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Contacts.Update();
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

    void DisplayContact()
    {
        //create an instance of the booking list
        clsContactUsCollection Contacts = new clsContactUsCollection();
        //find the record to update
        Contacts.ThisContact.Find(ContactId);
        //display the data for this record
        txtEmail.Text = Contacts.ThisContact.Email;
        txtName.Text = Contacts.ThisContact.Name;
        txtMessage.Text = Contacts.ThisContact.Message;
    }
}