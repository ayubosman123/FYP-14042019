using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;


namespace Resturant_Testing
{
    [TestClass]
    public class tstReviewsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //test to see if it exists
            Assert.IsNotNull(AllReviews);
        }

        [TestMethod]
        public void ReviewListOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsReviews> TestList = new List<clsReviews>();
            //add an item to the list
            //create the item of test data
            clsReviews TestItem = new clsReviews();
            //set its properties
            TestItem.ReviewId = 1;
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllReviews.ReviewList = TestList;//test to see that it exists
            Assert.AreEqual(AllReviews.ReviewList, TestList);
        }

        [TestMethod]
        public void ThisReviewPropertyOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //create some test data to assign to the property
            //add an item to the list
            clsReviews TestItem = new clsReviews();
            //set its properties
            TestItem.ReviewId = 1;
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //assign the data to the property
            AllReviews.ThisReview = TestItem;//test to see that it exists
            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }


        [TestMethod]
        public void CountReviewList()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsReviews> TestList = new List<clsReviews>();
            //add an item to the list
            //create the item of test data
            clsReviews TestItem = new clsReviews();
            //set its properties
            TestItem.ReviewId = 1;
            TestItem.Email = "ayubosman@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllReviews.ReviewList = TestList;//test to see that it exists
            Assert.AreEqual(AllReviews.Count, TestList.Count);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsReviews> TestList = new List<clsReviews>();
            //add an item to the list
            //create the item of test data
            clsReviews TestItem = new clsReviews();
            //set its properties
            TestItem.Email = "ayubosm@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllReviews.ReviewList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllReviews.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection("Fbloggs");
            //create an instance of test data
            clsReviews TestItem = new clsReviews();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.Email = "ayubosman1231@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //TestItem.UserName = "FBloggs";
            //set ThisCustomer to validate test data
            AllReviews.ThisReview = TestItem;
            //add the record
            PK = AllReviews.Add();
            //set primary key of test data
            TestItem.ReviewId = PK;
            //find the record
            AllReviews.ThisReview.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection("Fbloggs");
            //create an instance of test data
            clsReviews TestItem = new clsReviews();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            //TestItem.CustomerID = 3;
            TestItem.Email = "ayub@hotmail.co.uk";
            TestItem.Exp = "ayubosman@hotmail.co.uk";
            TestItem.Improveexp = "ayubosman@hotmail.co.uk";
            //set ThisCustomer to validate test data
            AllReviews.ThisReview = TestItem;
            //add the record
            PK = AllReviews.Add();
            //set primary key of test data
            TestItem.ReviewId = PK;
            //find the record
            AllReviews.ThisReview.Find(PK);
            //delete the record
            AllReviews.Delete();
            //now find the record
            Boolean Found = AllReviews.ThisReview.Find(PK);
            //test to see that it exists
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection("Fbloggs");
            //create an instance of test data
            clsReviews TestItem = new clsReviews();
            //var to store primary key
            Int32 PK = 0;
            //set the properties
            TestItem.Email = "ayubosman2@hotmail.co.uk";
            TestItem.Exp = "man@hotmail.co.uk";
            TestItem.Improveexp = "osman@hotmail.co.uk";
            //set ThisCustomer to validate test data
            AllReviews.ThisReview = TestItem;
            //add the record
            PK = AllReviews.Add();
            //set primary key of test data
            TestItem.ReviewId = PK;
            //modify the record
            TestItem.Email = "bossman@hotmail.co.uk";
            TestItem.Exp = "ayub@hotmail.co.uk";
            TestItem.Improveexp = "osman@hotmail.co.uk";
            //set the record based on the new record
            AllReviews.ThisReview = TestItem;
            //update the record
            AllReviews.Update();
            //find the record
            AllReviews.ThisReview.Find(PK);
            //test to see that it exists
            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }
        [TestMethod]
        public void FilterbyEmailOK()
        {
            clsReviews TestItem = new clsReviews();
            //create an instance of the class we want to create
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            //create an instance of the filtered data
            clsReviewsCollection FilteredReviews = new clsReviewsCollection("");
            //apply a blank string (should return all records)
            FilteredReviews.FilterbyEmail("");
            //test to see the two values are the same
            Assert.AreEqual(AllReviews.Count, FilteredReviews.Count);
        }

        [TestMethod]
        public void FilterbyEmailNoneFound()
        {
            //create an instance of the filtered data
            clsReviewsCollection FilteredReviews = new clsReviewsCollection(" ");
            //apply a blank string (should return all records)
            FilteredReviews.FilterbyEmail("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredReviews.Count);
        }

        [TestMethod]
        public void FilterbyeMailTestDataFound()
        {
            //create an instance of the filtered data
            clsReviewsCollection FilteredReviews = new clsReviewsCollection("");
            //var to store outcome
            Boolean OK = true;
            //apply a primary key value 
            FilteredReviews.FilterbyEmail("ayubosman@hotmail.co.uk");
            //check the correct number of records are found
            if (FilteredReviews.Count == 12)
            {
                //check the first record is ID 2
                if (FilteredReviews.ReviewList[0].ReviewId != 2000)
                {
                    OK = false;
                }
                // check that the first record is ID
                if (FilteredReviews.ReviewList[11].ReviewId != 2016)
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
