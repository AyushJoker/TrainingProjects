//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace LoginTestForm
//{
//    public class Tests
//    {
//        LoginClass log;
//        [SetUp]
//        public void Setup()
//        {
//            log = new LoginClass();
//        }
//        [TearDown]
//        public void Destroy()
//        {
//            log = null;
//        }



//        [Test]
//        [TestCase("", "", "user or pwd is null")]
//        [TestCase("Admin", "admin", "Welcome Admin")]
//        public void Test1(string user, string pwd, string expected)
//        {

//            string actual = null;
//            actual = log.Login(user, pwd);

//            Assert.AreEqual(expected, actual, "Message not same");
//        }



//        [Test]
//        public void DoesNotEndWith()
//        {
//            StringAssert.DoesNotEndWith("x","abc");
//        }
//        [Test]
//        public void EndsWith()
//        {
//            StringAssert.EndsWith("abc", "abc");
//            StringAssert.EndsWith("abc", "123abc");
//            StringAssert.StartsWith("ABC", "abc");
//        }
//        [Test]
//        public void CaseInsensitiveCompare()
//        {
//            StringAssert.AreEqualIgnoringCase("name", "NAME");
//        }
//    }
//}