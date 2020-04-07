using System;
using UnityEngine;
using System.Collections.Generic;

namespace AI
{
   
    public class Dijkstra : IPathFinder
    {
        private List<Vector2Int> Grid;
        Vector2Int currentNode;
        Dictionary<Vector2Int, Vector2Int> ancestors = new Dictionary<Vector2Int, Vector2Int>();
        Queue<Vector2Int> frontier = new Queue<Vector2Int>();

        public Dijkstra(List<Vector2Int> grid) { Grid = grid; }

        public IEnumerable<Vector2Int> FindPath(Vector2Int start, Vector2Int goal)
        {
            currentNode = start;
            frontier.Enqueue(currentNode);

            ancestors.Add(currentNode, default);
            while (frontier.Count > 0)
            {
                currentNode = frontier.Dequeue();
                if (currentNode == goal) { break; }

                foreach (Vector2Int currentNeighbor in Tools.DirectionTools.Dirs)
                {
                    Vector2Int next = currentNode + currentNeighbor;
                    if (Grid.Contains(next))
                    {
                        if (!ancestors.ContainsKey(next))
                        {
                            frontier.Enqueue(next);
                            ancestors.Add(next, currentNode);
                        }
                    }
                }


            }

            List<Vector2Int> path = new List<Vector2Int>();
            if (ancestors.ContainsKey(goal))
            {
                while (currentNode != start)
                {
                    path.Add(currentNode);
                    currentNode = ancestors[currentNode];
                }
                path.Add(currentNode);
                path.Reverse();
                return path;
            }

            else { Debug.LogError("No path to goal"); return null; }

           // return path;
        }

        //private Vector2Int[] Neighbors
        //{
        //	get
        //		{ Vector2Int[] returnValue =


        //		return null;}

        //}
    }
}