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

[CreateAssetMenu(fileName = "MapManager", menuName = "ScriptableObjects/MapManager", order = 1)]
public class MapManager : ScriptableObject
{
    [SerializeField] private MapTypes _mapType = MapTypes.map_1;
    [SerializeField] private GameObject _pathTile = null;
    [SerializeField] private GameObject _obstacleTile = null;
    [SerializeField] private GameObject _towerDefenseOne = null;
    [SerializeField] private GameObject _towerDefenseTwo = null;
    [SerializeField] private GameObject _enemy_Base_Building_Model = null;
    [SerializeField] private GameObject _player_Base_Building_Model = null;

    [SerializeField] private int cellSize = 2;
    [SerializeField] List<string> _lines = new List<string>(); //take out _ to work for Mandy's

    //for my generateMap
    [SerializeField] List<string> lines = new List<string>();
    static string line = "";

    List<GameObject> obj_TileList = new List<GameObject>();
    public List<GameObject> TileList
    {
        get => obj_TileList;
    }

    public Vector2Int start;
    public Vector2Int end;

    //private void Awake()
    //{

    //}

    //private void OnValidate()
    //{
    //    obj_TileList = null;
    //}

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
        obj_TileList.Clear();
        string filePath = ProjectPaths.RESOURCES_MAP_SETTINGS + Enum.GetName(typeof(MapTypes), _mapType) + ".txt";


        using (StreamReader sr = new StreamReader(filePath))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        line = sr.ReadLine();
            //        lines.Add(line);

            //    }

            //    string mapString = "";
            //    foreach (string line in lines)
            //    {
            //        if(line == "#")
            //        {
            //            break;
            //        }

            //        mapString += line;

            //    }
            //    char[] characters = mapString.ToCharArray();

            //    Debug.Log(mapString);


            //read until #


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

                GameObject obj_Tile = Instantiate(objectType, new Vector3(x, 0, z), Quaternion.identity);
                switch(item)
                {
                    case '0':
                        obj_TileList.Add(obj_Tile);
                        break;
                    case '8':                        
                        start =new Vector2Int(Mathf.RoundToInt(obj_Tile.transform.position.x*0.5f), Mathf.RoundToInt(obj_Tile.transform.position.z * 0.5f));
                        obj_TileList.Add(obj_Tile);
                        break;
                    case '9':
                        end = new Vector2Int(Mathf.RoundToInt(obj_Tile.transform.position.x * 0.5f), Mathf.RoundToInt(obj_Tile.transform.position.z * 0.5f));
                        obj_TileList.Add(obj_Tile);
                        break;
                    default:
                        break;
                }

                //obj_TileList.Add(obj_Tile);

            }

        }
    }

    //public Vector2Int CalculatePath()
    //{
    //    foreach(Vector2Int )
    //}

}
