
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    //gets the objects that are around the object
    public static class DirectionTools
    {
        public static readonly Vector2Int[] Dirs = { Vector2Int.up, Vector2Int.right, Vector2Int.down, Vector2Int.left };

        public static readonly Dictionary<Direction, Vector2Int> DirectionToVector2Int =
        new Dictionary<Direction, Vector2Int>
        {
            { Direction.Up,    Vector2Int.up    },
            { Direction.Right, Vector2Int.right },
            { Direction.Down,  Vector2Int.down  },
            { Direction.Left,  Vector2Int.left  }
        };
        
        public static readonly Dictionary<Vector2Int, Direction> Vector2IntToDirection =
        new Dictionary<Vector2Int, Direction>
        {
            { Vector2Int.up,    Direction.Up    },
            { Vector2Int.right, Direction.Right },
            { Vector2Int.down,  Direction.Down  },
            { Vector2Int.left,  Direction.Left  }
        };

        public static bool InBounds(int topX, int topY, int x, int y)
        {
            return x >= 0 && x < topX && y >= 0 && y < topY;
        }

        public static bool InBounds(Vector2Int bounds, Vector2Int current)
        {
            return InBounds(bounds.x, bounds.y, current.x, current.y);
        }
    }
}