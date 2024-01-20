using System;
using System.Configuration;
using Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string con = ConfigurationManager.AppSettings["connection"];
            SqlManager sqlManager = new SqlManager(con);
            sqlManager.Open();
            string valueToupdate = "update156";
            int id = 1;
            var value = sqlManager.Execute($"Update Project1 set Content =  '{valueToupdate}' where id = {id}");
            sqlManager.Close();
            sqlManager.Open();
            var select = sqlManager.Execute($"select * from Project1 where id = {id}");
            select.Read();
            var valueExpected = select["Content"];
            sqlManager.Close();
            Assert.AreEqual(valueExpected, valueToupdate);
          
        }
    }
}
