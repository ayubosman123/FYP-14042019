using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyClassLibrary
{
    public class clsReviewsCollection
    {
        private string mUserName;
        public clsReviewsCollection(string UserName)
        {
            // create an insance of the class
            //clsBooking ThisBooking = new clsBooking(UserName.Identity.Name);
            // var to store the count of records 
            mUserName = UserName;
        }

        //prive data memeber for the list
        List<clsReviews> mReviewList = new List<clsReviews>();
        //private member thisAddress
        clsReviews mThisReview = new clsReviews();


        //public property for the booking list
        public List<clsReviews> ReviewList
        {
            get
            {
                //return the private data
                return mReviewList;
            }
            set
            {
                //set the private data
                mReviewList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mReviewList.Count;
            }
            set
            {
                //later
            }
        }

        public clsReviews ThisReview
        {
            get
            {
                //return the private data
                return mThisReview;
            }
            set
            {
                //set the private data
                mThisReview = value;
            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisReview = new clsDataConnection();
            //set the parameters for the stored procedure
            ThisReview.AddParameter("@Email", mThisReview.Email);
            ThisReview.AddParameter("@exp", mThisReview.Exp);
            ThisReview.AddParameter("@improveexp", mThisReview.Improveexp);
            ThisReview.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            return ThisReview.Execute("sproc_tblReviews_Insert");

        }

        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection ThisReview = new clsDataConnection();
            //set the parameters for the stored procedure
            ThisReview.AddParameter("@ReviewId", mThisReview.ReviewId);
            ThisReview.AddParameter("@Email", mThisReview.Email);
            ThisReview.AddParameter("@exp", mThisReview.Exp);
            ThisReview.AddParameter("@improveexp", mThisReview.Improveexp);
            ThisReview.AddParameter("@UserName", mUserName);
            //execute the query returning primary key of new record
            ThisReview.Execute("sproc_tblReviews_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ReviewId", mThisReview.ReviewId);
            
            //execute the stored procdure
            DB.Execute("sproc_tblReviews_Delete");
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
            mReviewList = new List<clsReviews>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank booking
                clsReviews ThisReview = new clsReviews();
                ThisReview.ReviewId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewId"]);
                ThisReview.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ThisReview.Exp = Convert.ToString(DB.DataTable.Rows[Index]["Exp"]);
                ThisReview.Improveexp = Convert.ToString(DB.DataTable.Rows[Index]["Improveexp"]);
                //add the records into a private data member
                mReviewList.Add(ThisReview);
                //point to the next record
                Index++;
            }
        }

        //constructor for the class
        public clsReviewsCollection()
        {
            //object for the data connection
            clsDataConnection ThisReview = new clsDataConnection();
            //execute the store procedure
            ThisReview.Execute("sproc_FiltertblReviewsALL");
            //populate the array list
            PopulateArray(ThisReview);
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
            DB.Execute("sproc_FiltertblReviewsbyEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}