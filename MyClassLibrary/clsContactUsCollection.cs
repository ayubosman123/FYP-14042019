using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsContactUsCollection
    {

        private string mUserName;
        public clsContactUsCollection(string UserName)
        {
            // create an insance of the class
            //clsBooking ThisBooking = new clsBooking(UserName.Identity.Name);
            // var to store the count of records 
            mUserName = UserName;
        }


        //prive data memeber for the list
        List<clsContactUs> mContactList = new List<clsContactUs>();
        //private member thisAddress
        clsContactUs mThisContact = new clsContactUs();


        //public property for the booking list
        public List<clsContactUs> ContactList
        {
            get
            {
                //return the private data
                return mContactList;
            }
            set
            {
                //set the private data
                mContactList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mContactList.Count;
            }
            set
            {
                //later
            }
        }
        public clsContactUs ThisContact
        {
            get
            {
                //return the private data
                return mThisContact;
            }
            set
            {
                //set the private data
                mThisContact = value;
            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisContact = new clsDataConnection();
            //set the parameters for the stored procedure
            ThisContact.AddParameter("@Email", mThisContact.Email);
            ThisContact.AddParameter("@Name", mThisContact.Name);
            ThisContact.AddParameter("@Message", mThisContact.Message);
            ThisContact.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            return ThisContact.Execute("sproc_tblContactUs_Insert");

        }

        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisContact = new clsDataConnection();
            //set the parameters for the stored procedure
            ThisContact.AddParameter("@ContactId", mThisContact.ContactId);
            ThisContact.AddParameter("@Email", mThisContact.Email);
            ThisContact.AddParameter("@Name", mThisContact.Name);
            ThisContact.AddParameter("@Message", mThisContact.Message);
            ThisContact.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            ThisContact.Execute("sproc_tblContactUs_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ContactId", mThisContact.ContactId);
           
            //execute the stored procdure
            DB.Execute("sproc_tblContactUs_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count.
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array lsit
            mContactList = new List<clsContactUs>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank booking
                clsContactUs ThisContact = new clsContactUs();
                ThisContact.ContactId = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactId"]);
                ThisContact.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ThisContact.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ThisContact.Message = Convert.ToString(DB.DataTable.Rows[Index]["Message"]);
                //add the records into a private data member
                mContactList.Add(ThisContact);
                //point to the next record
                Index++;
            }
        }

        //constructor for the class
        public clsContactUsCollection()
        {
            //object for the data connection
            clsDataConnection ThisContact = new clsDataConnection();
            //execute the store procedure
            ThisContact.Execute("sproc_FiltertblContactUsALL");
            //populate the array list
            PopulateArray(ThisContact);
        }

        public void FilterbyEmail(string Email) //string UserName)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Email", Email);
            DB.AddParameter("@UserName", mUserName);
            // execute the stored procedure 
            DB.Execute("sproc_FiltertblContactUsbyEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
