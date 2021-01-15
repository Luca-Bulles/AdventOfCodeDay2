﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            PasswordPolicyChecker passwordPolicy = new PasswordPolicyChecker();
            int correctPasswords = passwordPolicy.PasswordControl();
            Assert.AreEqual(447, correctPasswords);
        }

        [TestMethod]
        public void DoesPasswordPolicyPartTwoWork()
        {
            PasswordPolicyChecker passwordPolicy = new PasswordPolicyChecker();
            int correctPasswords = passwordPolicy.PasswordControlPartTwo();
            Assert.AreEqual(249, correctPasswords);
        }
    }
}
