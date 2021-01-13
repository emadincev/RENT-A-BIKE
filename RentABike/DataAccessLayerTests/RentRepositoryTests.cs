using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Tests
{
    [TestClass()]
    public class RentRepositoryTests
    {
        RentRepository rR;
        Product p;
        User u;

        [TestInitialize]
        public void init()
        {
            rR = new RentRepository();
            p = new Product();
            u = new User();
        }
        [TestMethod()]
        public void GetAllProductsTest()
        {
           p = new Product();
            rR.InserProduct(p);
            Assert.IsNotNull(rR.GetAllProducts());
        }
        [TestMethod()]
        public void GetAllUsersTest()
        {
            u = new User();
            rR.InserUser(u);
            Assert.IsNotNull(rR.GetAllUsers());
        }
        [TestMethod()]
        public void InsertUser()
        {
            u = new User();
            rR.InserUser(u);
            Assert.IsNotNull(rR.GetAllUsers());
        }
        [TestMethod()]
        public void InsertProduct()
        {
            p = new Product();
            rR.InserProduct(p);
            Assert.IsNotNull(rR.GetAllProducts());
        }
        


    }
}