using StackStudentsAzureDevOps.Api.Controllers;
using StackStudentsAzureDevOps.Services.InMemoryData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackStudentsAzureDevOps.Tests
{
    [TestClass]
    public class UserControllerGetAllTest
    {
        [TestMethod]
        public void TryToGetOkStatusCode()
        {
            ApplicationDbContext.Initialize();

            // Get Controller
            var controller = new UserController();

            // Find a record by USD code
            var result = controller.GetAll();

            // Check
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}
