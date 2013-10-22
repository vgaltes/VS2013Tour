using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeLensDemo.Tests
{
    [TestClass]
    public class CodeLensTests
    {
        [TestMethod]
        public void GetUserName_ReturnsDemoUser()
        {
            var userService = new UserService();

            Assert.AreEqual("Demo user", userService.GetUserName(1));
        }

        [TestMethod]
        public void GetUserName_ReturnsDemoUser2()
        {
            var userService = new UserService();

            Assert.AreEqual("Demo user 2", userService.GetUserName(1));
        }
    }
}
