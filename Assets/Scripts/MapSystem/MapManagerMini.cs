using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;
using TowerDefense;

public enum Maps { map_1, map_2, map_3 };

public class MapManagerMini : MonoBehaviour
{
    //variable for my enums
    [SerializeField] private Maps maps = Maps.map_1;
    string path;

    private void Awake()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        //access to my data
        path = ProjectPaths.RESOURCES_MAP_SETTINGS + Enum.GetName(typeof(Maps), maps) + ".txt";
        StreamReader reader = new StreamReader(path);

        //List<string> indices = new List<string>();
        //for (int mapData = 0; i < length; i++)
        //{

        //}
    }




    //

    //list that goes through the txt


    //save data to a split array
    //translate

}
