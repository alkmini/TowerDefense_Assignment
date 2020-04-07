using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public interface IPathFinder
    {
        IEnumerable<Vector2Int> FindPath(Vector2Int start, Vector2Int goal);
    }
}