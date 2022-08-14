//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CollectionDemo
//{
//    public class Tests
//    {
//        Collection obj;
//        [SetUp]
//        public void Setup()
//        {
//            obj = new Collection();
//        }
//        [TearDown]
//        public void ClosUp()
//        {
//            obj = null;
//        }



//        [Test]
//        public void Test1()
//        {
//            List<string> list = obj.GetNames();
//            CollectionAssert.AllItemsAreUnique(list, "names not unique");
//        }
//    }
//}