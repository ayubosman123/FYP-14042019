using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace Resturant_Testing
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBookings);

        }

        [TestMethod]
        public void BookingListOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookRef = 1;
            TestItem.useremail = "ayubosman@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingsList = TestList;//test to see that it exists
            Assert.AreEqual(AllBookings.BookingsList, TestList);
        }

        [TestMethod]
        public void ThisBookingPropertyOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsBooking TestBooking = new clsBooking();
            //set its properties
            TestBooking.BookRef = 1;
            TestBooking.useremail = "ayubosman@hotmail.co.uk";
            TestBooking.DateBooked = DateTime.Now.Date;
            TestBooking.TimeBooked = DateTime.Now.Date.ToString();
            TestBooking.GuestsBooked = "10";
            TestBooking.DiningBooked = "Dinner";
            //assign the data to the property
            AllBookings.ThisBookings = TestBooking;//test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestBooking);
        }


        [TestMethod]
        public void CountBookingsList()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookRef = 1;
            TestItem.useremail = "ayubosman@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingsList = TestList;//test to see that it exists
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.useremail = "ayubosman@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingsList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection("Fbloggs");
            //create an instance of test data
            clsBooking TestItem = new clsBooking();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.useremail = "ayubosmantest@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //TestItem.UserName = "FBloggs";
            //set ThisCustomer to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection("Fbloggs");
            //create an instance of test data
            clsBooking TestItem = new clsBooking();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.useremail = "ayubosmantest@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //set ThisCustomer to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //delete the record
            AllBookings.Delete();
            //now find the record
            Boolean Found = AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection("Fbloggs");
            //create an instance of test data
            clsBooking TestItem = new clsBooking();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            TestItem.useremail = "ayubosmantest@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //set ThisCustomer to validate test data
            AllBookings.ThisBookings = TestItem;
            //add the record
            PK = AllBookings.Add();
            //set primary key of test data
            TestItem.BookRef = PK;
            //modify the record
            TestItem.useremail = "ayubosmantest@hotmail.co.uk";
            TestItem.DateBooked = DateTime.Now.Date;
            TestItem.TimeBooked = DateTime.Now.Date.ToString();
            TestItem.GuestsBooked = "10";
            TestItem.DiningBooked = "Dinner";
            //set the record based on the new record
            AllBookings.ThisBookings = TestItem;
            //update the record
            AllBookings.Update();
            //find the record
            AllBookings.ThisBookings.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllBookings.ThisBookings, TestItem);
        }
        [TestMethod]
        public void FilterbyuseremailOK()
        {
            clsBooking TestItem = new clsBooking();
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create an instance of the filtered data
            clsBookingCollection FilteredBookings = new clsBookingCollection(" ");
            //apply a blank string (should return all records)
            FilteredBookings.Filterbyemail("");
            //test to see the two values are the same
            Assert.AreEqual(AllBookings.Count, FilteredBookings.Count);
        }

        [TestMethod]
        public void FilterbyuseremailNoneFound()
        {
            //create an instance of the filtered data
            clsBookingCollection AllBookings = new clsBookingCollection(" ");
            //apply a blank string (should return all records)
            AllBookings.Filterbyemail("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, AllBookings.Count);
        }

        [TestMethod]
        public void FilterbyuseremailTestDataFound()
        {
            //create an instance of the filtered data
            clsBookingCollection FilteredBookings = new clsBookingCollection(" ");
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredBookings.Filterbyemail("ayubosman@hotmail.co.uk");
            //check the correct number of records are found
            if (FilteredBookings.Count == 20)
            {
                //check the first record is ID 2
                if (FilteredBookings.BookingsList[0].BookRef != 2000)
                {
                    OK = true;
                }
                // check that the first record is ID
                if (FilteredBookings.BookingsList[1].BookRef != 2002)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see there are records
            Assert.IsTrue(OK);
        }
    }
}
