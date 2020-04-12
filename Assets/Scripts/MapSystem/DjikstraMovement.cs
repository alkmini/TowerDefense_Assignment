using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    /// <summary>
    /// Sets the enemies' movement according to the pathfinding algorith
    /// </summary>
    public class DjikstraMovement : MonoBehaviour
    {
        #region Members
        private Dijkstra m_PathFinding;
        [SerializeField] private MapManager m_MapManager = null;

        private List<Vector2Int> m_ShortestPath = new List<Vector2Int>();
        private List<GameObject> m_MyTileList = new List<GameObject>();
        private List<Vector2Int> m_PathList = new List<Vector2Int>();

        private float m_MaxMoveTimer = 0.25f;
        private float m_MoveTimer = 0;
        private int m_Iterator = 0;
        #endregion Members


        private void Start()
        {
            m_MyTileList = m_MapManager.TileList;
            m_PathList = new List<Vector2Int>();

            foreach (GameObject go in m_MyTileList)
            {
                m_PathList.Add(new Vector2Int(Mathf.RoundToInt(go.transform.position.x * 0.5f), Mathf.RoundToInt(go.transform.position.z * 0.5f)));
            }
            m_PathFinding = new Dijkstra(m_PathList);
            //get constructor to work;
            //get only the tiles that we can go on
            //

            m_ShortestPath = m_PathFinding.FindPath(m_MapManager.start, m_MapManager.end) as List<Vector2Int>; //it returns a list of the Vector2
            
        }

        public void ResetMovement()
        {
           m_MaxMoveTimer = 0.25f;
           m_MoveTimer = 0;
           m_Iterator = 0;
        }

        

        private void Update()
        {
            if (m_MoveTimer >= m_MaxMoveTimer)
            {
                transform.position = new Vector3(m_ShortestPath[m_Iterator].x*2.0f, transform.position.y, m_ShortestPath[m_Iterator].y*2.0f);
                if (m_Iterator < m_ShortestPath.Count - 1)
                {
                    m_Iterator++;
                }
                else
                {
                    gameObject.SetActive(false);
                    
                }
                m_MoveTimer = 0;

            }
            m_MoveTimer += Time.deltaTime;
        }
    }
}