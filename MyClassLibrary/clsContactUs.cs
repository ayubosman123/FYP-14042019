using System;

namespace MyClassLibrary
{

    public class clsContactUs
    {

        //private string mUserName;
        //public clsContactUs(string UserName)
        //{
        //    // create an insance of the class
        //    //clsContactUs ThisContact = new clsContactUs(UserName.Identity.Name);
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
        //public property for BookRef
        private Int32 mContactId;
        public int ContactId
        {
            get
            {
                //return private data
                return mContactId;
            }
            set
            {
                //set the value of the private data member
                mContactId = value;
            }
        }

        private string mEmail;
        //public property for payment type
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

        private string mName;
        //public property for payment type
        public string Name
        {
            get
            {
                //return private data
                return mName;
            }
            set
            {
                //set the the value of the private memeber
                mName = value;
            }
        }
        private string mMessage;
        //public property for payment type
        public string Message
        {
            get
            {
                //return private data
                return mMessage;
            }
            set
            {
                //set the the value of the private memeber
                mMessage = value;
            }
        }


        //private string to store all details
        private string mAllDetails;
        public string AllDetails
        {
            get
            {
                //
                return ("  Email : " + mEmail + "  Name: " + mName + "  Message : " + mMessage);
            }

            set
            {
                mAllDetails = value;
            }
        }

        public string Valid(string Email, string Name, string Message)
        {
            //create a string variable to store the error
            String OK = "";


            /// validation 


            if (Email.Length < 6)
            {
                OK = OK + " Email is too short :  ";
            }

            if (Email.Length > 30)
            {
                OK = OK + " Email is too long :    ";
            }


            //if statement for contactNo

            if (Name.Length < 1)
            {
                OK = OK + " Name is too short : ";
            }
            if (Name.Length > 25)
            {
                OK = OK + " Name is too short : ";
            }


            ///if statement for houseno

            if (Message.Length < 1)
            {
                OK = OK + " Your Message is too short  :";
            }
            if (Message.Length > 50)
            {
                OK = OK + " Your Message is too long  :";
            }

            return OK;

        }

        public bool Find(int ContactId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@ContactId", ContactId);
            //execute stored procedure
            DB.Execute("sproc_FiltertblContactUsbyPK");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mContactId = Convert.ToInt32(DB.DataTable.Rows[0]["ContactId"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mMessage = Convert.ToString(DB.DataTable.Rows[0]["Message"]);

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

