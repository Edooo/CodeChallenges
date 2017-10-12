using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RainForecast.Tests
{
    [TestFixture]
    public class TerrainAnalyzerTests
    {
        private ITerrainAnalyzer _terrainAnalyzer;
        [SetUp]
        public void BeforeTest()
        {
            _terrainAnalyzer = CreateSut();
        }
        [Test]
        [TestCase(new[]{ 8, 7, 7, 6 }, 0)]
        [TestCase(new[]{ 5, 6, 7, 8 }, 0)]
        [TestCase(new[]{ 5, 5, 5, 5 }, 0)]
        [TestCase(new[]{ 1, 5, 3, 7, 2 }, 2)]
        [TestCase(new[]{ 6, 7, 10, 7, 6 }, 0)]
        [TestCase(new[]{ 5, 3, 7, 2, 6, 4, 5, 9, 1, 2 }, 14)]
        [TestCase(new[]{ 2, 6, 3, 5, 2, 8, 1, 4, 2, 2, 5, 3, 5, 7, 4, 1 }, 35)]
        public void Test_terrain_analizer_return_correct_number_of_rain_spots(int[] testData, int expected)
        {
            int actual = _terrainAnalyzer.Analyze(testData);

            Assert.AreEqual(expected, actual);
        }
        private static TerrainAnalyzer CreateSut()
        {
            return new TerrainAnalyzer();
        }
    }
}
