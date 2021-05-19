using FluentAssertions;
using LeetCode.OtherProblems.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Medium
{
    [TestClass]
    public class UniquePathsIITest
    {
        [TestMethod]
        public void UniquePathWithObstaclesTestCase1()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 1},
                new[] {0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(1);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase2()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 0, 0},
                new[] {0, 1, 0},
                new[] {0, 0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(2);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase3()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 0, 0},
                new[] {0, 1, 0},
                new[] {1, 0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(1);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase4()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 0, 1},
                new[] {0, 1, 0},
                new[] {1, 0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(0);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase5()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 1, 1},
                new[] {0, 0, 0},
                new[] {0, 0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(3);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase6()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 1}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(0);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase7()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(1);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase8()
        {
            var obstacleGrid = new[]
            {
                new[] {0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(1);
        }

        [TestMethod]
        public void UniquePathWithObstaclesTestCase9()
        {
            var obstacleGrid = new[]
            {
                new[] {1}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(0);
        }
        
        [TestMethod]
        public void UniquePathWithObstaclesTestCase10()
        {
            var obstacleGrid = new[]
            {
                new[] {0},
                new[] {0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(1);
        }
        
        [TestMethod]
        public void UniquePathWithObstaclesTestCase11()
        {
            var obstacleGrid = new[]
            {
                new[] {0, 0},
                new[] {1, 1},
                new[] {0, 0}
            };

            UniquePathsII.UniquePathsWithObstacles(obstacleGrid).Should().Be(0);
        }
    }
}