using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Resturant_Testing
{
    [TestClass]
    public class tstContactUs
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //test to see if it exists
            Assert.IsNotNull(AContact);
        }

        [TestMethod]
        public void ContactIdOK()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //create some test data
            Int32 ContactId = 1;
            AContact.ContactId = ContactId;
            //test to see if it exists
            Assert.AreEqual(AContact.ContactId, ContactId);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //create some test data
            string Email = " ayubosman@hotmail.co.uk";
            AContact.Email = Email;
            //test to see if it exists
            Assert.AreEqual(AContact.Email, Email);
        }

        [TestMethod]
        public void NameOK()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //create some test data
            string Name = " Ayub Osman ";
            AContact.Name = Name;
            //test to see if it exists
            Assert.AreEqual(AContact.Name, Name);
        }


        [TestMethod]
        public void MessageOK()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //create some test data
            string Message = " It was a nice experience. Thanks  ";
            AContact.Message = Message;
            //test to see if it exists
            Assert.AreEqual(AContact.Message, Message);


        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsContactUs TestItem = new clsContactUs();
            //boolean variable to store the result of the validisation
            Boolean Found = false;
            //create some test data to use the method 
            Int32 ContactId = 2000;
            //Invoke the method
            Found = TestItem.Find(ContactId);
            //test to see if it exists 
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmailMinMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " 12@45";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "123@56";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailMinPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "123@567";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung1234567";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung12345671";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung123456711";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "Samsung@23454 ";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = "Samsung1234567@Samsung12345671Samsung1234567@Samsung12345671";
            string Name = " Ayub Osman ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void NameExtremeMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void NameMinMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void NameBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "A";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void NameMinPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "AB";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void NameMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Abcdefhjk lmnjhsaqwe  ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void NameBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "Abcdefhjklmnjhsaqwea";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void NameMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = "Abcdefhjklmnjhsaqweaanaaaaaaaaaaaaaaaaaaaaa ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Avsafghnmjhg ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Samsung65325621478583254441251 ";
            string Message = " It was a nice experience. Thanks  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void MessageExtremeMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = "";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void MessageMinMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = " ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageBoundaryMin()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = "A";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageMinPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = " AB ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageMaxMinus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = " AbcdefhjklmnjhsaqweAbcdefhjklmnjhsaqwea  ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageBoundaryMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = " AabcdefhjklmnjhsaqweAbcdefhjklmnjhsaqwea ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageMaxPlus1()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = "AabcdefhjklmnjhsaqweAbcdefhjklmnjhsaqweaa";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageMid()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = "AvsafghnmjhAvsafghnmjhg ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void MessageExtremeMax()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string Email = " ayubosman@hotmail.co.uk";
            string Name = " Ayub Osman ";
            string Message = "Samsung65325621478583254441251Samsung65325621478583254441251 ";
            //invoke method
            OK = AContact.Valid(Email, Name, Message);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestContactIdFound()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ContactId = 2000;
            //invoke method
            Found = AContact.Find(ContactId);
            //check the Customer ID
            if (AContact.ContactId != 2000)
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
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ContactId = 2000;
            //invoke method
            Found = AContact.Find(ContactId);
            //check the Customer ID
            if (AContact.Email != "ayubosman@hotmail.co.uk")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestNameFound()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ContactId = 2000;
            //invoke method
            Found = AContact.Find(ContactId);
            //check the Customer ID
            if (AContact.Name != "Ayub Osman")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

        ///Testing Find Method///
        [TestMethod]
        public void TestMessageFound()
        {
            //create a new instance of the class we want to create
            clsContactUs AContact = new clsContactUs();
            //string variable to store result of validation
            Boolean Found = false;
            //create some test data to assign to property
            Int32 ContactId = 2000;
            //invoke method
            Found = AContact.Find(ContactId);
            //check the Customer ID
            if (AContact.Message != "Nice Restaurant")
            {
                Found = false;
            }
            //test to see if it exists
            Assert.IsTrue(Found);
        }

    }
}
    

