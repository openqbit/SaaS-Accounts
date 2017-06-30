using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using OpenQbit.Accounts.DAL.DataAccess;
using OpenQubit.Account.Common.Models;

namespace OpenQbit.Accounts.Test.DAL
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void Create()
        {
            IRepository repo = new Repository();
            Account account = new Account()
            {
               
                ParentAccountId = 12,
                Name = "CashBook",
                CustomerId = 1
            };
            bool response = repo.Create<Account>(account);
            repo.Save();
            Account account1 = repo.Find<Account>(B => B.Name == "CashBook");


            string expected = "CashBook";
            string actual = account1.Name;

            Assert.AreEqual(expected, actual);
        }
    }
}
