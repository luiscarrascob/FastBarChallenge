using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastBar.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBar.Controllers.Tests
{
    [TestClass()]
    public class ManageControllerTests
    {
        [TestMethod()]
        public async void IndexTest()
        {

            var controller = new ManageController();

            Assert.IsNull(controller.UserManager);
            Assert.IsNull(controller.SignInManager);


            var result = await controller.Index(ManageController.ManageMessageId.AddPhoneSuccess);

            Assert.Fail();
        }
    }
}