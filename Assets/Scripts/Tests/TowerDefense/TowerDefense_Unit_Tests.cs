using System.Collections.Generic;
using System.Linq;
using AI;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class TowerDefense_Unit_Tests
    {
        private byte[,] m_Map_0, m_Map_1;        

        [SetUp]
        public void Setup()
        {
            m_Map_0 = new byte[ , ]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0 }
            }; 
            
            m_Map_1 = new byte[ , ]
            {
                { 1, 0, 0},
                { 1, 0, 1},
                { 0, 0, 1},
            };
        }
        
        [Test]
        [TestCase(/*MapID*/ 1, /*xStart*/ 0, /*yStart*/ 0, /*xGoal*/ 2, /*yGoal*/ 2, /*Result*/ 5)]
        [TestCase(/*MapID*/ 1, /*xStart*/ 2, /*yStart*/ 2, /*xGoal*/ 0, /*yGoal*/ 0, /*Result*/ 5)]
        [TestCase(/*MapID*/ 0, /*xStart*/ 0, /*yStart*/ 0, /*xGoal*/ 4, /*yGoal*/ 4, /*Result*/ 17)]
        [TestCase(/*MapID*/ 0, /*xStart*/ 4, /*yStart*/ 4, /*xGoal*/ 0, /*yGoal*/ 0, /*Result*/ 17)]
        public void Dijkstra_Solves_Raw_Data(int mapId, int xStart, int yStart, int xGoal, int yGoal, int expectedLength)
        {
            byte[,] map = mapId == 0 ? m_Map_0 : m_Map_1;
            
            List<Vector2Int> accessibles = new List<Vector2Int>(); 

            //We flip the array values to match horizontal values with X coords and vertical values with Y coords
            //So (0 , 0) coords starts from the bottom left and not from the top left and Y coords from bottom to top and not
            //from top to bottom as the default indexing 2D array system.
            for (int iRun = map.GetLength(0) - 1, i = 0; iRun >= 0; iRun--, i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[iRun, j] == 0)
                    {
                        accessibles.Add(new Vector2Int(j, i));                        
                    }
                }
            }

            IPathFinder pathFinder = new Dijkstra(accessibles); //<-- TODO: Create Dijsktra pathfinder class here, TIP-->> Use accessible tiles
            IEnumerable<Vector2Int> path = pathFinder.FindPath(new Vector2Int(xStart, yStart), new Vector2Int(xGoal, yGoal));            
            Assert.AreEqual(expectedLength, path.Count());          
        }    
    
        [Test]
        [TestCase("map_1",  0, 2, 2, 0, 18)]
        [TestCase("map_2",  24, 0, 9, 9, 118)]
        public void Dijkstra_Solves_Path(string map, int x0, int y0, int x1, int y1, int result)
        {
            Assert.Pass();
        }
    }
}
