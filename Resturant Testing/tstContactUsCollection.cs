using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace Resturant_Testing
{
    [TestClass]
    public class tstContactUsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //test to see if it exists
            Assert.IsNotNull(AContact);
        }

        [TestMethod]
        public void ContactListOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsContactUs> TestList = new List<clsContactUs>();
            //add an item to the list
            //create the item of test data
            clsContactUs TestItem = new clsContactUs();
            //set its properties
            TestItem.ContactId = 1;
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Name = "Ayub Osman";
            TestItem.Message = " I Loved the meal. Thanks ! ";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AContact.ContactList = TestList;//test to see that it exists
            Assert.AreEqual(AContact.ContactList, TestList);
        }

        [TestMethod]
        public void ThisContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsContactUs TestContact = new clsContactUs();
            //set its properties
            TestContact.ContactId = 1;
            TestContact.Email = "ayubosman@hotmail.co.uk";
            TestContact.Name = "10";
            TestContact.Message = "Dinner";
            //assign the data to the property
            AContact.ThisContact = TestContact;//test to see that it exists
            Assert.AreEqual(AContact.ThisContact, TestContact);
        }

        [TestMethod]
        public void CountContactList()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsContactUs> TestList = new List<clsContactUs>();
            //add an item to the list
            //create the item of test data
            clsContactUs TestItem = new clsContactUs();
            //set its properties
            TestItem.ContactId = 1;
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Name = "Ayub Osman";
            TestItem.Message = " I Loved the meal. Thanks ! ";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AContact.ContactList = TestList;//test to see that it exists
            Assert.AreEqual(AContact.Count, TestList.Count);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsContactUs> TestList = new List<clsContactUs>();
            //add an item to the list
            //create the item of test data
            clsContactUs TestItem = new clsContactUs();
            //set its properties
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Name = "Ayub Osman";
            TestItem.Message = " I Loved the meal. Thanks ! ";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AContact.ContactList = TestList;
            //test to see that it exists
            Assert.AreEqual(AContact.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection("Fbloggs");
            //create an instance of test data
            clsContactUs TestItem = new clsContactUs();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.Email = "ayu@hotmail.co.uk1";
            TestItem.Name = "Ayub Osman1";
            TestItem.Message = " I Loved the meal. Thanks !1 ";
            //TestItem.UserName = "FBloggs";
            //set ThisCustomer to validate test data
            AContact.ThisContact = TestItem;
            //add the record
            PK = AContact.Add();
            //set primary key of test data
            TestItem.ContactId = PK;
            //find the record
            AContact.ThisContact.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AContact.ThisContact, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection("Fbloggs");
            //create an instance of test data
            clsContactUs TestItem = new clsContactUs();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.Email = "ayubos@hotmail.co.uk1";
            TestItem.Name = "Ayub Osman1";
            TestItem.Message = " I Loved the meal. Thanks !1 ";
            //set ThisCustomer to validate test data
            AContact.ThisContact = TestItem;
            //add the record
            PK = AContact.Add();
            //set primary key of test data
            TestItem.ContactId = PK;
            //find the record
            AContact.ThisContact.Find(PK);
            //delete the record
            AContact.Delete();
            //now find the record
            Boolean Found = AContact.ThisContact.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection("Fbloggs");
            //create an instance of test data
            clsContactUs TestItem = new clsContactUs();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            TestItem.Email = "a@hotmail.co.uk2";
            TestItem.Name = "Ayub Osman2";
            TestItem.Message = " I Loved the meal. Thanks !2 ";
            //set ThisCustomer to validate test data
            AContact.ThisContact = TestItem;
            //add the record
            PK = AContact.Add();
            //set primary key of test data
            TestItem.ContactId = PK;
            //modify the record
            TestItem.Email = "a@hotmail.co.uk1";
            TestItem.Name = "Ayub Osman1";
            TestItem.Message = " I Loved the meal. Thanks !1 ";
            //set the record based on the new record
            AContact.ThisContact = TestItem;
            //update the record
            AContact.Update();
            //find the record
            AContact.ThisContact.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AContact.ThisContact, TestItem);
        }
        [TestMethod]
        public void FilterbyEmailOK()
        {
            clsContactUs TestItem = new clsContactUs();
            //create an instance of the class we want to create
            clsContactUsCollection AContact = new clsContactUsCollection();
            //create an instance of the filtered data
            clsContactUsCollection FilteredContacts = new clsContactUsCollection("");
            //apply a blank string (should return all records)
            FilteredContacts.FilterbyEmail("");
            //test to see the two values are the same
            Assert.AreEqual(AContact.Count, FilteredContacts.Count);
        }

        [TestMethod]
        public void FilterbyEmailNoneFound()
        {
            //create an instance of the filtered data
            clsContactUsCollection FilteredContacts = new clsContactUsCollection(" ");
            //apply a blank string (should return all records)
            FilteredContacts.FilterbyEmail("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredContacts.Count);
        }

        [TestMethod]
        public void FilterbyEmailTestDataFound()
        {
            //create an instance of the filtered data
            clsContactUsCollection FilteredContacts = new clsContactUsCollection(" ");
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredContacts.FilterbyEmail("ayubosman@hotmail.co.uk");
            //check the correct number of records are found
            if (FilteredContacts.Count == 12)
            {
                //check the first record is ID 2
                if (FilteredContacts.ContactList[0].ContactId != 2000)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredContacts.ContactList[9].ContactId != 2013)
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
