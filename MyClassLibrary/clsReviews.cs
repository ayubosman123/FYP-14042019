using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{

    public class clsReviews
    {

        //private string mUserName;
        //public clsReviews(string UserName)
        //{
        //    // create an insance of the class
        //    // clsReviews ThisReview = new clsReviews(UserName.Identity.Name);
        //    // var to store the count of records 
        //    mUserName = UserName;
        //}



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
        //private data memeber for the BookRef property
        private Int32 mReviewId;

        //public property for BookRef
        public int ReviewId
        {
            get
            {
                //return private data
                return mReviewId;
            }
            set
            {
                //set the value of the private data member
                mReviewId = value;
            }
        }

        //public property for fName
        private string mEmail;
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set the the value of the private memeber
                mEmail = value;
            }

        }
        private string mExp;
        public string Exp
        {
            get
            {
                //return private data
                return mExp;
            }
            set
            {
                //set the the value of the private memeber
                mExp = value;
            }

        }

        private string mImproveexp;
        public string Improveexp
        {
            get
            {
                //return private data
                return mImproveexp;
            }
            set
            {
                //set the the value of the private memeber
                mImproveexp = value;
            }

        }

        private string mAllDetails;

        //public property for AllDetails
        public string AllDetails
        {
            get
            {
                //return private data
                return ("  Email : " + mEmail + "  Exp: " + mExp + "  Improveexp : " + mImproveexp);
            }

            set
            {
                //set the the value of the private memeber
                mAllDetails = value;
            }
        }




        public string Valid(string Email, string Exp, string Improveexp)
        {
            //create a string variable to store the error
            String OK = "";



            /// validation 


            if (Email.Length < 6)
            {
                OK = OK + "Email is too short :  ";
            }

            if (Email.Length > 30)
            {
                OK = OK + " Email is too long :    ";
            }


            //if statement for Time

            if (Exp.Length < 1)
            {
                OK = OK + " Experience is too short : ";
            }

            if (Exp.Length > 50)
            {
                OK = OK + " Experience is too short : ";
            }

            ///if statement for dining booked

            if (Improveexp.Length < 1)
            {
                OK = OK + " Improve Experience is too short :";
            }
            if (Improveexp.Length > 50)
            {
                OK = OK + " Improve Experience is too long :";
            }

            return OK;

        }



        public bool Find(int ReviewId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@ReviewId", ReviewId);
            //execute stored procedure
            DB.Execute("sproc_FiltertblReviewsbyPK");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mReviewId = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewId"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mExp = Convert.ToString(DB.DataTable.Rows[0]["Exp"]);
                mImproveexp = Convert.ToString(DB.DataTable.Rows[0]["Improveexp"]);

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

