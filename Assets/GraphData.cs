using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{

    [CreateAssetMenu(fileName = "MyData", menuName = "ScriptableObjects/MakeScriptableObject", order = 1)]
    public class GraphData : ScriptableObject
    {
        public Dictionary<Vector2Int, bool> graph;

    }
}