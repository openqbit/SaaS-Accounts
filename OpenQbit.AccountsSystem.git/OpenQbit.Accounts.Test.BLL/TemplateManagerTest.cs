using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQbit.Accounts.BLL.AccountService;
using OpenQubit.Account.Common.Models;

namespace OpenQbit.Accounts.Test.BLL
{
    [TestClass]
    public class TemplateManagerTest
    {

        [TestMethod]
        public void AddTemplateTest()
        {
            

            TemplateManager templateManager = new TemplateManager();

            templateManager.AddTemplateDetail("abc", "", "", "");

            TransactionTemplate newTemplate  = templateManager.FindTemplate(10);

            string expected = newTemplate.Name;
            string actual = "abc";

            Assert.AreNotEqual(newTemplate, null);

            Assert.AreEqual(expected, actual);


        }

    }
}