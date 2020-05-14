using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class GraphExtensions
    {
        public static void AStar(AStarLocation start, AStarLocation target, int[][] map)
        {
            AStarLocation current = null;
            var openList = new List<AStarLocation>();
            var closedList = new List<AStarLocation>();
            int g = 0;

            // start by adding the original position to the open list  
            openList.Add(start);

            while (openList.Count > 0)
            {
                // get the square with the lowest F score  
                var lowest = openList.Min(l => l.F);
                current = openList.First(l => l.F == lowest);

                // add the current square to the closed list  
                closedList.Add(current);

                // remove it from the open list  
                openList.Remove(current);

                // if we added the destination to the closed list, we've found a path  
                if (closedList.FirstOrDefault(l => l.X == target.X && l.Y == target.Y) != null)
                    break;

                var adjacentSquares = GetWalkableAdjacentSquares(current.X, current.Y, map);
                g = current.G + 1;

                foreach (var adjacentSquare in adjacentSquares)
                {
                    // if this adjacent square is already in the closed list, ignore it  
                    if (closedList.FirstOrDefault(l => l.X == adjacentSquare.X
                        && l.Y == adjacentSquare.Y) != null)
                        continue;

                    // if it's not in the open list...  
                    if (openList.FirstOrDefault(l => l.X == adjacentSquare.X
                        && l.Y == adjacentSquare.Y) == null)
                    {
                        // compute its score, set the parent  
                        adjacentSquare.G = g;
                        adjacentSquare.H = ComputeHScore(adjacentSquare.X, adjacentSquare.Y, target.X, target.Y);
                        adjacentSquare.F = adjacentSquare.G + adjacentSquare.H;
                        adjacentSquare.Parent = current;

                        // and add it to the open list  
                        openList.Insert(0, adjacentSquare);
                    }
                    else
                    {
                        // test if using the current G score makes the adjacent square's F score  
                        // lower, if yes update the parent because it means it's a better path  
                        if (g + adjacentSquare.H < adjacentSquare.F)
                        {
                            adjacentSquare.G = g;
                            adjacentSquare.F = adjacentSquare.G + adjacentSquare.H;
                            adjacentSquare.Parent = current;
                        }
                    }
                }
            }

            AStarLocation end = current;

            // assume path was found; let's show it  
            while (current != null)
            {
                Debug.Log("X = " + current.X + " Y = " + current.Y);
                current = current.Parent;
            }

            if (end != null)
            {
                Debug.Log("Path : " + end.G);
            }
        }

        public static List<AStarLocation> GetWalkableAdjacentSquares(int x, int y, int[][] map)
        {
            var proposedLocations = new List<AStarLocation>()
            {
                new AStarLocation { X = x, Y = y - 1 },
                new AStarLocation { X = x, Y = y + 1 },
                new AStarLocation { X = x - 1, Y = y },
                new AStarLocation { X = x + 1, Y = y },
            };

            return proposedLocations.Where(l =>
                l.Y >= 0 && l.Y < map.Length &&
                l.X >= 0 && l.X < map[0].Length &&
                map[l.Y][l.X] == 0).ToList();
        }

        public static int ComputeHScore(int x, int y, int targetX, int targetY)
        {
            return Math.Abs(targetX - x) + Math.Abs(targetY - y);
        }
    }
}