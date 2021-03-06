﻿using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        public static int i = 0;
        
        [TestMethod]
        [Owner("some1")]
        [Priority(1)]
        public void WillPassOnReRun1()
        {
            Console.WriteLine("Result level attachments");
            Debug.WriteLine("Debug Attachemts");
            Assert.IsTrue(i++ % 4 == 0);
        }


        [TestMethod]
        [Owner("some2")]
        [Priority(2)]
        public void WillPassOnReRun11()
        {
            Console.WriteLine("Result level attachments");
            Assert.IsTrue(i++ % 4 == 0);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Result level attachments");
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Result level attachments");
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0,1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0,1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0,1);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest11
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest13
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest14
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest15
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }


    [TestClass]
    public class UnitTest21
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest22
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest23
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest24
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest25
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest31
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest32
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest33
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest34
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

    [TestClass]
    public class UnitTest35
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0, 1);
        }
    }

}
