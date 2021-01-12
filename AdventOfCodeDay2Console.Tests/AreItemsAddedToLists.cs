using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console.Tests
{
    [TestClass]
    public class AreItemsAddedToLists
    {
        [TestMethod]
        public void MinimalNumberValuesAreAddedToList()
        {
            //Arrange
            Database database = new Database();

            //Act
            database.ReadTextFile();
            //Assert 
            Assert.IsNotNull(database.TextFileMinimalNumber);
            Assert.AreEqual(3, database.TextFileMinimalNumber[0]);
        }
        [TestMethod]
        public void MaximalNumberValuesAreAddedToList()
        {
            //Arrange
            Database database = new Database();

            //Act
            database.ReadTextFile();
            //Assert 
            Assert.IsNotNull(database.TextFileMaximalNumber);
            Assert.AreEqual(4, database.TextFileMaximalNumber[0]);
        }
        [TestMethod]
        public void RequiredLetterValuesAreAddedToList()
        {
            //Arrange
            Database database = new Database();
            List<char> TextFileRequiredLetterTest = new List<char>("l");
            //Act
            database.ReadTextFile();
            //Assert 
            Assert.IsNotNull(database.TextFileRequiredLetter);
            Assert.AreEqual(TextFileRequiredLetterTest[0], database.TextFileRequiredLetter[0]);
        }
        [TestMethod]
        public void PasswordValuesAreAddedToList()
        {
            //Arrange
            Database database = new Database();

            //Act
            database.ReadTextFile();
            //Assert 
            Assert.IsNotNull(database.TextFilePassword);
            Assert.AreEqual("vdcv", database.TextFilePassword[0]);
        }
    }
}
