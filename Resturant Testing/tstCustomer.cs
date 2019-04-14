using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Resturant_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(AnCustomer);
        }

        //Firstname
        [TestMethod]
        public void FirstNameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //create some test data
            string FirstName = "fred";
            TestItem.FirstName = FirstName;
            //test to see if it exists
            Assert.AreEqual(TestItem.FirstName, FirstName);

        }

        [TestMethod]
        public void SurnameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //create some test data
            string Surname = "bloggs";
            TestItem.Surname = Surname;
            //test to see if it exists
            Assert.AreEqual(TestItem.Surname, Surname);

        }

        //Email
        [TestMethod]
        public void EMailExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //create some test data
            string EMail = "me@me.com";
            TestItem.EMail = EMail;
            //test to see if it exists
            Assert.AreEqual(TestItem.EMail, EMail);

        }

        //Gender
        [TestMethod]
        public void GenderExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string Gender = "Male";
            TestItem.Gender = Gender;
            //test to see if it exists
            Assert.AreEqual(TestItem.Gender, Gender);

        }

        [TestMethod]
        public void DateExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer(); 
            //create some test data
            DateTime Date = DateTime.Now.Date;
            AnCustomer.dateOfBirth = Date;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.dateOfBirth, Date);

        }

        [TestMethod]
        public void ContactNumberExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string ContactNumber = "01161234567";
            AnCustomer.ContactNumber = ContactNumber;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.ContactNumber, ContactNumber);

        }

        [TestMethod]
        public void HouseNoExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //create some test data
            string HouseNo = "2";
            TestItem.HouseNo = HouseNo;
            //test to see if it exists
            Assert.AreEqual(TestItem.HouseNo, HouseNo);

        }

        [TestMethod]
        public void PostCodeExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string PostCode = "LE5";
            AnCustomer.PostCode = PostCode;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.PostCode, PostCode);
        }

        [TestMethod]
        public void TitleExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string Title = "Mr";
            AnCustomer.Title = Title;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.Title, Title);
        }
    
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //boolean variable to store the result of the validisation
            Boolean Found = false;
            //create some test data to use the method 
            Int32 Id = 2002;
            //Invoke the method
            Found = TestItem.Find(Id);
            //test to see if it exists 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "s";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "Abcdefhjklmnjhsaqweaaaaa";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "Abcdefhjklmnjhsaqweaaaaaa";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "Abcdefhjklmnjhsaqweaaaaaaa";
            string Surname = "bloggs";
            string DateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345";
            string EMail = "me@me.com";
            string FlatNo = "1";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, DateOfBirth, Gender, ContactNumber, EMail, FlatNo, HouseNo, PostCode);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void FirstNameBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fr";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fredaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "A";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggggggggggggggggggggggggggggggggggggggggggggggggggggggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggsgwwwwwgggaaaaaggggg";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void SurnameBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggsaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-17).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-18).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-149).AddDays(+364).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-150).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestBoundryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-150).AddDays(+1).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestBoundryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-75).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");

        }

        [TestMethod]
        public void DateTestInvalidData()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = "122";
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void DateTestExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-500).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345671111111111111111111111111111111111111111111111111111";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "1234567121";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345671211";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "12345671211";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void ContactNumberBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "123456";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }


        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer();
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "011612345611111111112222222222222222222222222222127";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer();
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer();
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "a@.uk";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer();
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "aa@.uk";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer();
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "aaa@.uk";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung1234567";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456711";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Samsung1234567@Samsung123456711a";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "Sams@ng12.com ";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaame@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "1";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "12";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "12345";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "100000";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "1234567";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void HouseNoExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "";
            string PostCode = "LE5 6HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");

        }

        [TestMethod]
        public void PostCodeExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 1";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = " LE1 12";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE21234";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE20AW0333";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE20AW0333";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 1234";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE55555555555555 688888888888888888888888886HP";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = " LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "M";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = " LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Fe";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "femal";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Female";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "Females";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "fem";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "maleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleExtremeMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = " LE1 123";
            string Title = "";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleMinMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "M";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = " LE1 123";
            string Title = "Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleBoundaryMinPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mrs";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void TitlerBoundaryMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Misss";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Doctor";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleBoundaryMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Doctors";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleBoundaryMid()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mrss";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreEqual(AllOK, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); 
            //string variable to store the results of the validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE1 123";
            string Title = "Mrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if result correct
            Assert.AreNotEqual(AllOK, "");
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestIdFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.Id != 2002)
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestSurnameFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.Surname != "osman")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestdateOfBirthFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.dateOfBirth != Convert.ToDateTime("Aug 17 1991 12:00AM"))
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.PostCode != "LE6 4GT")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestEMailFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.EMail != "ayubosman@hotmail.co.uk")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.HouseNo != "45")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }


        ///Testing Find Method///
        [TestMethod]
        public void TestContactNumberFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.ContactNumber != "554545")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.FirstName != "ayub")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.Title != "mr")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            //create a new instance of the class we want to create
            clsCustomer AC = new clsCustomer();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 Id = 2002;
            //invoke method
            Found = AC.Find(Id);
            //check the Customer ID
            if (AC.Gender != "male")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }
    }
}

