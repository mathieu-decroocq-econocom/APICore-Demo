using NUnit.Framework;
using APICore_Demo.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace APICore_Demo.Tests
{
    public class WeatherForecastControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_ReturnWeatherForFiveDays()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            IEnumerable<WeatherForecast> result = controller.Get();

            Assert.AreEqual(5, result.Count());
        }
    }
}