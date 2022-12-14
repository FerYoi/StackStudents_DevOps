using StackStudentsAzureDevOps.Api.Controllers;
using StackStudentsAzureDevOps.Services.InMemoryData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StackStudentsAzureDevOps.Tests
{
    [TestClass]
    public class UserControllerGetTest
    {
        [TestMethod]
        public void TryToGetNotFoundStatusCode()
        {
            ApplicationDbContext.Initialize();

            // Get Controller
            var controller = new UserController();

            // Find a record by USD code
            var result = controller.Get(Guid.NewGuid());

            // Check
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
