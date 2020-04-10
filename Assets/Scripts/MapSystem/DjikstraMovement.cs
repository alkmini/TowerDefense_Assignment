using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class DjikstraMovement : MonoBehaviour
    {
        Dijkstra pathFinding;
        [SerializeField] MapManager mapManager = null;

        List<Vector2Int> shortestPath = new List<Vector2Int>();
        List<GameObject> myTileList = new List<GameObject>();
        List<Vector2Int> pathList = new List<Vector2Int>();

        float MaxMoveTimer = 0.25f;
        float moveTimer = 0;
        int iterator = 0;


        private void Start()
        {
            myTileList = mapManager.TileList;
            pathList = new List<Vector2Int>();

            foreach (GameObject go in myTileList)
            {
                pathList.Add(new Vector2Int(Mathf.RoundToInt(go.transform.position.x * 0.5f), Mathf.RoundToInt(go.transform.position.z * 0.5f)));
            }
            pathFinding = new Dijkstra(pathList);
            //get constructor to work;
            //get only the tiles that we can go on
            //


            shortestPath = pathFinding.FindPath(mapManager.start, mapManager.end) as List<Vector2Int>; //it returns a list of the Vector2
        }

        public void ResetMovement()
        {
           MaxMoveTimer = 0.25f;
           moveTimer = 0;
           iterator = 0;
        }

        

        private void Update()
        {
            if (moveTimer >= MaxMoveTimer)
            {
                transform.position = new Vector3(shortestPath[iterator].x*2.0f, transform.position.y, shortestPath[iterator].y*2.0f);
                if (iterator < shortestPath.Count - 1)
                {
                    iterator++;
                }
                else
                {
                    gameObject.SetActive(false);
                    
                }
                moveTimer = 0;

            }
            moveTimer += Time.deltaTime;
        }
    }
}