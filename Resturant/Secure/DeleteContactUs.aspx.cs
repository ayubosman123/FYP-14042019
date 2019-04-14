using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class DeleteContactUs : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ContactId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        ContactId = Convert.ToInt32(Session["ContactId"]);
    }
    protected void btnBackToContactUs_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteContact();
        //directs back to the login page 
        Response.Redirect("DefaultContactUs.aspx");

    }
    void DeleteContact()
    {
        ////function to delete the selected record


        //create a new instance of the Customer collection
        clsCustomerCollection ContactList = new clsCustomerCollection(User.Identity.Name);
        //find the record to delete
        ContactList.ThisCustomer.Find(ContactId);
        //delete the record
        ContactList.Delete(); ;
    }
}