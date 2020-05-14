using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class AStarTests
    {
        [Test]
        public void AStarTest()
        {
            int[][] map = new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 1, 0, 1, 0 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 0, 1, 0 },
            };

            var start = new AStarLocation() { X = 0, Y = 0 };
            var end = new AStarLocation() { X = map.Length - 1, Y = map[0].Length - 1 };

            GraphExtensions.AStar(start, end, map);
        }
    }
}