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
            Database database = new Database();
            database.ReadTextFile();
            Assert.IsNotNull(database.TextFileMinimalNumber);
            Assert.AreEqual(3, database.TextFileMinimalNumber[0]);
        }
        [TestMethod]
        public void MaximalNumberValuesAreAddedToList()
        {
            Database database = new Database();
            database.ReadTextFile();
            Assert.IsNotNull(database.TextFileMaximalNumber);
            Assert.AreEqual(4, database.TextFileMaximalNumber[0]);
        }
        [TestMethod]
        public void RequiredLetterValuesAreAddedToList()
        {
            Database database = new Database();
            List<char> TextFileRequiredLetterTest = new List<char>("l");
            database.ReadTextFile();
            Assert.IsNotNull(database.TextFileRequiredLetter);
            Assert.AreEqual(TextFileRequiredLetterTest[0], database.TextFileRequiredLetter[0]);
        }
        [TestMethod]
        public void PasswordValuesAreAddedToList()
        {
            Database database = new Database();
            database.ReadTextFile();
            Assert.IsNotNull(database.TextFilePassword);
            Assert.AreEqual("vdcv", database.TextFilePassword[0]);
        }
    }
}
