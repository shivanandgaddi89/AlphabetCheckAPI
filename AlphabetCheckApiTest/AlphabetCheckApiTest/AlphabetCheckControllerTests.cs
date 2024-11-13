
using AlphabetCheckAPI.Controllers;
using AlphabetCheckAPI.Prop;
using Microsoft.AspNetCore.Mvc;
namespace AlphabetCheckApiTest
{
    [TestClass]
    public class AlphabetCheckControllerTests
    {
        private readonly AlphabetCheckAPIController _controller;
        
        public AlphabetCheckControllerTests()
        {
            _controller = new AlphabetCheckAPIController();
        }
        [TestMethod]
        public void CheckIf_InputContains_AllAlphabets_ValidInput_ReturnTrue()
        {
            var request = new AlphabetCheckRequest { Input = "abcdefghijklmnopqrstuvwxyz" };

            var result = _controller.CheckIfContainsAllAlphabets(request) as OkObjectResult;
            var response = result.Value as AlphabetCheckResponse;

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsTrue(response.ContainsAllAlphabets);
        }

        [TestMethod]
        public void CheckIf_InputContains_AllAlphabets_InValidInput_ReturnFalse()
        {
            var request = new AlphabetCheckRequest { Input = "The code compute" };

            var result = _controller.CheckIfContainsAllAlphabets(request) as OkObjectResult;
            var response = result.Value as AlphabetCheckResponse;

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsFalse(response.ContainsAllAlphabets);
        }
    }
}