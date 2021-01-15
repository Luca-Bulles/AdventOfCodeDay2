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
            //arrange
            Database database = new Database();

            //act
            database.ReadTextFile();

            //assert
            Assert.IsNotNull(database.TextFileMinimalNumber);
            Assert.AreEqual(3, database.TextFileMinimalNumber[0]);
        }
        [TestMethod]
        public void MaximalNumberValuesAreAddedToList()
        {
            //arrange
            Database database = new Database();

            //act
            database.ReadTextFile();

            //assert
            Assert.IsNotNull(database.TextFileMaximalNumber);
            Assert.AreEqual(4, database.TextFileMaximalNumber[0]);
        }
        [TestMethod]
        public void RequiredLetterValuesAreAddedToList()
        {
            //arrange
            Database database = new Database();
            List<char> TextFileRequiredLetterTest = new List<char>("l");

            //act
            database.ReadTextFile();

            //assert
            Assert.IsNotNull(database.TextFileRequiredLetter);
            Assert.AreEqual(TextFileRequiredLetterTest[0], database.TextFileRequiredLetter[0]);
        }
        [TestMethod]
        public void PasswordValuesAreAddedToList()
        {
            //arrange
            Database database = new Database();

            //act
            database.ReadTextFile();

            //assert
            Assert.IsNotNull(database.TextFilePassword);
            Assert.AreEqual("vdcv", database.TextFilePassword[0]);
        }
    }
}
