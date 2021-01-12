using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console.Tests
{
    [TestClass]
    public class DoesPasswordPolicyWork
    {
        [TestMethod]
        public void DoesPasswordPolicyPartOneWork()
        {
            //Arrange
            PasswordPolicy passwordPolicy = new PasswordPolicy();

            //Act
            int correctPasswords = passwordPolicy.PasswordControl();

            //Assert
            Assert.AreEqual(447, correctPasswords);
        }

        [TestMethod]
        public void DoesPasswordPolicyPartTwoWork()
        {
            //Arrange
            PasswordPolicy passwordPolicy = new PasswordPolicy();

            //Act
            int correctPasswords = passwordPolicy.PasswordControlPartTwo();

            //Assert
            Assert.AreEqual(249, correctPasswords);
        }
    }
}
