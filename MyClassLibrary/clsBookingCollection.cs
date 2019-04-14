using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsBookingCollection
    {


        private string mUserName;
        public clsBookingCollection (string UserName)
        {
            // create an insance of the class
            //clsBooking ThisBooking = new clsBooking(UserName.Identity.Name);
            // var to store the count of records 
            mUserName = UserName;
        }

        //public clsBookingCollection()
        //{
        //    //object for the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    //execute the store procedure
        //    DB.Execute("sproc_FiltertblRestBookingALL");
        //    //populate the array list
        //    PopulateArray(DB);
        //}

        //prive data memeber for the list
        List<clsBooking> mBookingsList = new List<clsBooking>();
        //private member thisAddress
        clsBooking mThisBooking = new clsBooking();


        //public property for the booking list
        public List<clsBooking> BookingsList
        {
            get
            {
                //return the private data
                return mBookingsList;
            }
            set
            {
                //set the private data
                mBookingsList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingsList.Count;
            }
            set
            {
                //later
            }
        }
        public clsBooking ThisBookings
        {
            get
            {
                //return the private data
                return mThisBooking;
            }
            set
            {
                //set the private data
                mThisBooking = value;
            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisBookings = new clsDataConnection();
            //set the parameters okfor the stored procedure
            ThisBookings.AddParameter("@useremail", mThisBooking.useremail);
            ThisBookings.AddParameter("@DateBooked", mThisBooking.DateBooked);
            ThisBookings.AddParameter("@TimeBooked", mThisBooking.TimeBooked);
            ThisBookings.AddParameter("@GuestsBooked", mThisBooking.GuestsBooked);
            ThisBookings.AddParameter("@DiningBooked", mThisBooking.DiningBooked);
            ThisBookings.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            return ThisBookings.Execute("sproc_tblRestBooking_Insert");

        }

        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisBookings = new clsDataConnection();
            //set the parameters for the stored procedure
            ThisBookings.AddParameter("@bookRef", mThisBooking.BookRef);
            ThisBookings.AddParameter("@useremail", mThisBooking.useremail);
            //user email missing
            ThisBookings.AddParameter("@DateBooked", mThisBooking.DateBooked);
            ThisBookings.AddParameter("@TimeBooked", mThisBooking.TimeBooked);
            ThisBookings.AddParameter("@GuestsBooked", mThisBooking.GuestsBooked);
            ThisBookings.AddParameter("@DiningBooked", mThisBooking.DiningBooked);
            ThisBookings.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            ThisBookings.Execute("sproc_tblRestBooking_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookRef", mThisBooking.BookRef);
            //execute the stored procdure
            DB.Execute("sproc_tblRestBooking_Delete");
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
            mBookingsList = new List<clsBooking>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank booking
                clsBooking ThisBookings = new clsBooking();
                ThisBookings.BookRef = Convert.ToInt32(DB.DataTable.Rows[Index]["bookRef"]);
                ThisBookings.useremail = Convert.ToString(DB.DataTable.Rows[Index]["useremail"]);
                ThisBookings.DateBooked = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateBooked"]);
                ThisBookings.TimeBooked = Convert.ToString(DB.DataTable.Rows[Index]["TimeBooked"]);
                ThisBookings.GuestsBooked = Convert.ToString(DB.DataTable.Rows[Index]["GuestsBooked"]);
                ThisBookings.DiningBooked = Convert.ToString(DB.DataTable.Rows[Index]["DiningBooked"]);
                //add the records into a private data member
                mBookingsList.Add(ThisBookings);
                //point to the next record
                Index++;
            }
        }

        //constructor for the class
        public clsBookingCollection()
        {
            //object for the data connection
            clsDataConnection ThisBookings = new clsDataConnection();
            //execute the store procedure
            ThisBookings.Execute("sproc_FiltertblRestBookingALL");
            //populate the array list
            PopulateArray(ThisBookings);
        }

        public void Filterbyemail(string email) //string UserName)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@useremail", email);
            DB.AddParameter("@UserName", mUserName);
            // execute the stored procedure 
            DB.Execute("sproc_FiltertblRestBookingbyuseremail");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}




