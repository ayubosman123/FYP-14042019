using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace Resturant_Testing
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //test to see if it exists
            Assert.IsNotNull(ABookings);
        }

        [TestMethod]
        public void BookRefOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            Int32 BookRef = 1;
            ABookings.BookRef = BookRef;
            //test to see if it exists
            Assert.AreEqual(ABookings.BookRef, BookRef);
        }

        [TestMethod]
        public void DateBookedOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            DateTime DateBooked = DateTime.Now.Date;
            ABookings.DateBooked = DateBooked;
            //test to see if it exists
            Assert.AreEqual(ABookings.DateBooked, DateBooked);
        }

        [TestMethod]
        public void TimeOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            string TimeBooked = "twelve";
            ABookings.TimeBooked = TimeBooked;
            //test to see if it exists
            Assert.AreEqual(ABookings.TimeBooked, TimeBooked);
        }

        [TestMethod]
        public void GuestsOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            string GuestsBooked = "3";
            ABookings.GuestsBooked = GuestsBooked;
            //test to see if it exists
            Assert.AreEqual(ABookings.GuestsBooked, GuestsBooked);
        }

        [TestMethod]
        public void DiningOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            string DiningBooked = "Dinner";
            ABookings.DiningBooked = DiningBooked;
            //test to see if it exists
            Assert.AreEqual(ABookings.DiningBooked, DiningBooked);
        }

        [TestMethod]
        public void UserEmailOK()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //create some test data
            string useremail = "ayubosman@hotmail.co.uk";
            ABookings.useremail = useremail;
            //test to see if it exists
            Assert.AreEqual(ABookings.useremail, useremail);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsBooking TestItem = new clsBooking();
            //boolean variable to store the result of the validisation
            Boolean Found = false;
            //create some test data to use the method 
            Int32 BookRef = 2000;
            //Invoke the method
            Found = TestItem.Find(BookRef);
            //test to see if it exists 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void useremailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void useremailMinMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "12@45";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void useremailMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "12@456";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void useremailMinPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "123@567";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void useremailMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "Samsung1234567@Samsung1234567";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void useremailBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "Samsung1234567@Samsung12345671";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void useremailMid()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "Samsung@23454";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }
        [TestMethod]
        public void useremailExtremeMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "Samsung@23333333333333333333333333333333333333333333333454";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve";
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DateBookedMinMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.AddDays(-1).ToString();
            string TimeBooked = "12"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DateBookedMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DateBookedMinPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.AddDays(+1).ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = ""; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
        [TestMethod]
        public void TimeBookedBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "1"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedMinPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "12"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "seventeensseventeensasdf"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "seventeensseventeensasdfd"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "seventeensseventeensasdfda"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedMid()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "seventeenasd"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void TimeBookedExtremeMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "seventeensseventeensasdfdseventeensseventeensasdfd "; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedMinMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "1";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedMinPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "12";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "seventeen";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "seventeens";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "seventeens ";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedMid()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "Twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void GuestsBookedExtremeMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "seventeensseventeensseventeens";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedMinMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " B ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedMinPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " BR ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinnerrrr ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinnerrrrr ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinnerrrrrs ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedMid()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Diner ";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DiningBookedExtremeMax()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string useremail = "ayubosman@hotmail.co.uk";
            string DateBooked = DateTime.Now.Date.ToString();
            string TimeBooked = "twelve"; ;
            string GuestsBooked = "twelve";
            string DiningBooked = " Dinn";
            //invoke method
            OK = ABookings.Valid(useremail, DateBooked, TimeBooked, GuestsBooked, DiningBooked);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestBookRefFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking ();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.BookRef != 2000)
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestuseremailFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.useremail != "ayubosman@hotmail.co.uk")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestDateBookedFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.DateBooked != Convert.ToDateTime("05/02/2018"))
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestTimeBookedFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.TimeBooked != "noon")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestGuestsBookedFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.GuestsBooked != "5000")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestDiningBookedFound()
        {
            //create a new instance of the class we want to create
            clsBooking ABookings = new clsBooking();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 BookRef = 2000;
            //invoke method
            Found = ABookings.Find(BookRef);
            //check the Customer ID
            if (ABookings.DiningBooked != "20000")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

    }
}




