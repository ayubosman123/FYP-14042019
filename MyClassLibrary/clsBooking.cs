using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{

    public class clsBooking
    {

        //private string mUserName;
        //public clsBooking(string UserName)
        //{
        //    // create an insance of the class
        //    //clsBooking ThisBooking = new clsBooking(UserName.Identity.Name);
        //    // var to store the count of records 
        //    mUserName = UserName;
        //}

        //public property for BookRef
        private Int32 mBookRef;
        public int BookRef
        {
            get
            {
                //return private data
                return mBookRef;
            }
            set
            {
                //set the value of the private data member
                mBookRef = value;
            }
        }

        //private data memeber for the date booked property
        //public property for DateBooked
        private DateTime mDateBooked;
        public DateTime DateBooked
        {
            get
            {
                //return private data
                return mDateBooked;
            }
            set
            {
                //set the value of the private data member
                mDateBooked = value;
            }
        }

        private string mDiningBooked;
        //public property for payment type
        public string DiningBooked
        {
            get
            {
                //return private data
                return mDiningBooked;
            }
            set
            {
                //set the the value of the private memeber
                mDiningBooked = value;
            }
        }
        private string mGuestsBooked;
        //public property for payment type
        public string GuestsBooked
        {
            get
            {
                //return private data
                return mGuestsBooked;
            }
            set
            {
                //set the the value of the private memeber
                mGuestsBooked = value;
            }
        }
        //private data memeber for the date booked property
        private string mTimeBooked;
        //public property for DateBooked
        public string TimeBooked
        {
            get
            {
                //return private data
                return mTimeBooked;
            }
            set
            {
                //set the value of the private data member
                mTimeBooked = value;
            }
        }

        //private data memeber for the payment type property
        private string museremail;
        //public property for payment type
        public string useremail
        {
            get
            {
                //return private data
                return museremail;
            }
            set
            {
                //set the the value of the private memeber
                museremail = value;
            }
        }

        //private string to store all details
        private string mAllDetails;
        public string AllDetails
        {
            get
            {
                //
                return ("  Dining : " + mDiningBooked + "  Guests: " + mGuestsBooked + " mTimeBooked" + "  useremail : " + museremail);
            }

            set
            {
                mAllDetails = value;
            }
        }

        private string mUserName;
        //public property for UserName
        public string UserName
        {
            get
            {
                //return private data
                return mUserName;
            }
            set
            {
                //set the the value of the private memeber
                mUserName = value;
            }

        }

        public string Valid(string useremail, string dateBooked, string timeBooked, string guestsBooked, string diningBooked)
        {
            //create a string variable to store the error
            String OK = "";
            //create a temporary variable to store date values
            DateTime DateTemp;




        ///validation 


                if (useremail.Length< 6)
                {
                    OK = OK + " Email is too short :  ";
                }

                if (useremail.Length > 30)
                {
                    OK = OK + " Email is too long :    ";
                }

            try
            {
                DateTemp = Convert.ToDateTime(dateBooked);

                if (DateTemp < DateTime.Now.Date)
                {
                    OK = OK + " Your booking cannot be in the past  ";
                }
                else if (DateTemp > DateTime.Now.Date)
                {
                    OK = OK + " Your booking cannot be in the future";
                }
            }
                catch
                {
                    OK = OK + " Incorrect date type entered please try in dd/mm/yyyy format  :  ";
                }


                 //if statement for Time

                if (timeBooked.Length< 1)
                {
                    OK = OK + " Time is too short : ";
                }
                if (timeBooked.Length> 25)
                {
                    OK = OK + " Time is too long : ";
                }


                 //if statement for guestsbooked

                if (guestsBooked.Length< 1)
                {
                    OK = OK + " GuestsBooked is too short  :";
                }
                if (guestsBooked.Length > 10)
                {
                    OK = OK + " GuestsBooked is too long  :";
                }

                 //if statement for dining booked

                if (diningBooked.Length< 1)
                {
                    OK = OK + " DiningBooked is too short :";
                }
                if (diningBooked.Length > 15)
                {
                    OK = OK + " DiningBooked is too long :";
                }

                return OK;

            }
        


        public bool Find(int BookRef)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@BookRef", BookRef);
            //execute stored procedure
            DB.Execute("sproc_FiltertblRestBookingbyPK");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mBookRef = Convert.ToInt32(DB.DataTable.Rows[0]["bookRef"]);
                museremail = Convert.ToString(DB.DataTable.Rows[0]["useremail"]);
                mDateBooked = Convert.ToDateTime(DB.DataTable.Rows[0]["DateBooked"]);
                mTimeBooked= Convert.ToString(DB.DataTable.Rows[0]["TimeBooked"]);
                mGuestsBooked= Convert.ToString(DB.DataTable.Rows[0]["GuestsBooked"]);
                mDiningBooked = Convert.ToString(DB.DataTable.Rows[0]["DiningBooked"]);
                //mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);


                //return an record has been found
                return true;
            }
            //if no record is found
            else
            {
                //record no record has been found
                return false;
            }
        }

    }
}