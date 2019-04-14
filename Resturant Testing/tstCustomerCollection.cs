using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace Resturant_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //add the item to the test list
            //AllCustomer.CustomerList(TestItem);
            //assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection("Fbloggs");
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //TestItem.UserName = "FBloggs";
            //set ThisCustomer to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.Id = PK;
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection("Fbloggs");
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //set ThisCustomer to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.Id = PK;
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection("Fbloggs");
            //create an instance of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //set ThisCustomer to validate test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PK = AllCustomer.Add();
            //set primary key of test data
            TestItem.Id = PK;
            //modify the record
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //set the record based on the new record
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void FilterbyeMailOK()
        {
            clsCustomer TestItem = new clsCustomer();
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection("");
            //apply a blank string (should return all records)
            FilteredCustomers.Filterbyemail("");
            //test to see the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbyeMailNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection(" ");
            //apply a blank string (should return all records)
            FilteredCustomers.Filterbyemail("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterbyeMailTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection(" ");
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredCustomers.Filterbyemail("ayubosman@hotmail.co.uk");
            //check the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the first record is ID 2
                if (FilteredCustomers.CustomerList[0].Id != 2002)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredCustomers.CustomerList[1].Id != 2007)
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
