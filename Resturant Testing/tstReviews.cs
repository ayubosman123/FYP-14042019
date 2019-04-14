using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Resturant_Testing
{
    [TestClass]
    public class tstReviews
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsReviews AReview = new clsReviews();
            //test to see if it exists
            Assert.IsNotNull(AReview);
        }

        [TestMethod]
        public void EmailExist()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //create some test data
            string Email = " ayubosman@hotmail.co.uk";
            TestItem.Email = Email;
            //test to see if it exists
            Assert.AreEqual(TestItem.Email, Email);

        }

        [TestMethod]
        public void ExpExist()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //create some test data
            string Exp = " loved it thanks ";
            TestItem.Exp = Exp;
            //test to see if it exists
            Assert.AreEqual(TestItem.Exp, Exp);
        }

        [TestMethod]
        public void ImproveexpExist()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //create some test data
            string Improveexp = " no mate loved it thanks ! ";
            TestItem.Improveexp = Improveexp;
            //test to see if it exists
            Assert.AreEqual(TestItem.Improveexp, Improveexp);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsReviews TestItem = new clsReviews();
            //boolean variable to store the result of the validisation
            Boolean Found = false;
            //create some test data to use the method 
            Int32 ReviewId = 2002;
            //Invoke the method
            Found = TestItem.Find(ReviewId);
            //test to see if it exists 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks gdfg";
            string Improveexp = "no mate loved it thanks!";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMinMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "12@45";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "123@56";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMinPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "123@567";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung1234567";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung12345671";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung123456711";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "Samsung@23454 ";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void EmailExtremeMax()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung12345671Samsung1234567@Samsung12345671";
            string Exp = " loved it thanks ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }


        [TestMethod]
        public void ExpMinMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = "";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMinBoundary()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = "I";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMinPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = "";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosmantest@hotmail.co.uk";
            string Exp = "Abcdefhjklmnjhsaqwe  ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosmantest@hotmail.co.uk";
            string Exp = "Abcdefhjklmnjhsaqwea  ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosmantest@hotmail.co.uk";
            string Exp = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpMid()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman123@hotmail.co.uk";
            string Exp = " aaaaaaaaaaaaaaaaaaaaaaaa  ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ExpExtremeMax()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " Samsung6532562147858325444125111111111111111111111111111 ";
            string Improveexp = " no mate loved it thanks ! ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpMinMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = " ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpMinBoundary()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = "A ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpMinPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = "JB   ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void ImproveexpMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = " Abcdefhjklmnjhsaqwe  ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = "Abcdefhjklmnjhsaqwea ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = " Abcdefhjklmnjhsaqweaa  ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void ImproveexpMid()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = "Avsafghnmjhg ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ImproveexpExtremeMax()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Exp = " loved it thanks ";
            string Improveexp = " Samsung6532562147858325444125111111111111111111111111111111  ";
            //invoke method
            AllOK = TestItem.Valid(Email, Exp, Improveexp);
            //test to see if it exists
            Assert.AreNotEqual(AllOK, "");
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestReviewIdFound()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ReviewId = 2000;
            //invoke method
            Found = TestItem.Find(ReviewId);
            //check the Customer ID
            if (TestItem.ReviewId != 2000)
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestEmailFound()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ReviewId = 2000;
            //invoke method
            Found = TestItem.Find(ReviewId);
            //check the Customer ID
            if (TestItem.Email != "ayubosman@hotmail.co.uk")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestExpFound()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ReviewId = 2000;
            //invoke method
            Found = TestItem.Find(ReviewId);
            //check the Customer ID
            if (TestItem.Exp != "good")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestImproveexpFound()
        {
            //create a new instance of the class we want to create
            clsReviews TestItem = new clsReviews(); ;
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ReviewId = 2000;
            //invoke method
            Found = TestItem.Find(ReviewId);
            //check the Customer ID
            if (TestItem.Improveexp != "good")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }
    }
}
