using System;
using System.Collections.Generic;
using System.IO;
using TowerDefense;
using UnityEngine;
using UnityEngine.Assertions;

public enum MapTypes
{
    map_1,
    map_2,
    map_3
}

/// <summary>
/// It reads the data of the map file.txt and stores the corresponding data to its unique gameobject holder. 
/// </summary>
[CreateAssetMenu(fileName = "MapManager", menuName = "ScriptableObjects/MapManager", order = 1)]
public class MapManager : ScriptableObject
{
    #region Members
    [SerializeField] private MapTypes _mapType = MapTypes.map_1;
    [SerializeField] private GameObject _pathTile = null;
    [SerializeField] private GameObject _obstacleTile = null;
    [SerializeField] private GameObject _towerDefenseOne = null;
    [SerializeField] private GameObject _towerDefenseTwo = null;
    [SerializeField] private GameObject _enemy_Base_Building_Model = null;
    [SerializeField] private GameObject _player_Base_Building_Model = null;

    [SerializeField] private int cellSize = 2;
   
    //for my generateMap
    [SerializeField] private List<string> lines = new List<string>();
    

    private List<GameObject> objTileList = new List<GameObject>();
    #endregion Members
    #region Property
    public List<GameObject> TileList
    {
        get => objTileList;
    }

    public Vector2Int start;
    public Vector2Int end;
    #endregion Property

    public void Initialize() 
    {
        Assert.IsNotNull(_pathTile, "Path tile game object has no reference.");
        Assert.IsNotNull(_obstacleTile, "Obstacle Tile game object has no reference.");
        Assert.IsNotNull(_towerDefenseOne, "Tower Defense type 1 has no reference.");
        Assert.IsNotNull(_towerDefenseTwo, "Tower Defense type 2 has no reference.");

        GenerateMap();
    }

    private void GenerateMap()
    {
        lines.Clear();
        objTileList.Clear();
        string filePath = ProjectPaths.RESOURCES_MAP_SETTINGS + Enum.GetName(typeof(MapTypes), _mapType) + ".txt";


        using (StreamReader sr = new StreamReader(filePath))
            
            do
            {
                string line = sr.ReadLine();
                if (line == "#")
                    break;
                lines.Add(line);

            } while (!sr.EndOfStream);

        for (int lineIndex = lines.Count - 1, rowIndex = 0; lineIndex >= 0; lineIndex--, rowIndex++)
        {
            string line = lines[lineIndex];
            for (int columnIndex = 0; columnIndex < line.Length; columnIndex++)
            {
                char item = line[columnIndex];

                float z = rowIndex * cellSize;
                float x = columnIndex * cellSize;

                GameObject objectType;
                switch (item)
                {
                    case '1':
                        objectType = _obstacleTile;
                        break;
                    case '2':
                        objectType = _towerDefenseOne;
                        break;
                    case '3':
                        objectType = _towerDefenseTwo;
                        break;
                    case '8':
                        objectType = _enemy_Base_Building_Model;
                        break;
                    case '9':
                        objectType = _player_Base_Building_Model;
                        break;
                    default:
                        objectType = _pathTile;
                        break;
                }

                GameObject objType = Instantiate(objectType, new Vector3(x, 0, z), Quaternion.identity);
                switch(item)
                {
                    case '0':
                        objTileList.Add(objType);
                        break;
                    case '8':                        
                        start =new Vector2Int(Mathf.RoundToInt(objType.transform.position.x*0.5f), Mathf.RoundToInt(objType.transform.position.z * 0.5f));
                        objTileList.Add(objType);
                        break;
                    case '9':
                        end = new Vector2Int(Mathf.RoundToInt(objType.transform.position.x * 0.5f), Mathf.RoundToInt(objType.transform.position.z * 0.5f));
                        objTileList.Add(objType);
                        break;
                    default:
                        break;
                }


            }

        }
    }

    
}
