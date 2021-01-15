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
            //arrange
            PasswordPolicy passwordPolicy = new PasswordPolicy();
            int correctPasswords = passwordPolicy.PasswordControl();

            //assert
            Assert.AreEqual(447, correctPasswords);
        }

        [TestMethod]
        public void DoesPasswordPolicyPartTwoWork()
        {
            //arrange
            PasswordPolicy passwordPolicy = new PasswordPolicy();
            int correctPasswords = passwordPolicy.PasswordControlPartTwo();

            //assert
            Assert.AreEqual(249, correctPasswords);
        }
    }
}
