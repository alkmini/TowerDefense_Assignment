using System.IO;
using System;
using System.Collections.Generic;
using TowerDefense;
using AI;
using UnityEngine;


[Serializable]
public struct EnemyCount
{
    public int Type1;
    public int Type2;
    public EnemyCount(int type1, int type2)
    {
        Type1 = type1;
        Type2 = type2;
    }
}

public class EnemyWaves : MonoBehaviour
{
    public MapTypes _mapType = default;
    public List<EnemyCount> WaveList = new List<EnemyCount>();
 



    //void Awake()
    //{
    //    
    //    SpawnWaves();
    //}



    public void PrepareWaves()
    {
        //gives the path
        string filePath = ProjectPaths.RESOURCES_MAP_SETTINGS + MapTypes.GetName(typeof(MapTypes), _mapType) + ".txt";
        Debug.Log(filePath);
        //reads the lines in the path
        string[] rows = File.ReadAllLines(filePath);

        //iterates through all the lines
        int breakPoint = 0;
        for(int i = 0; i < rows.Length; i++)
        {

            //saves the point where the symbol is
            if (rows[i].Contains("#"))
            {
                breakPoint = i + 1;
                break;
            }
        }

        //create empty array with required size
        string[] waves = new string[rows.Length - breakPoint];

        //copy this array to the other array
        Array.Copy(rows, breakPoint, waves, 0, rows.Length - breakPoint);


        //each wave in waves, turn into two ints
        //maybe use a string.somefunction() to separate the numbers?
        //add to List<Vector2Int>();
        foreach (string wave in waves)
        {
            string[] enemyCounts = wave.Split(' ');
            //Debug.Log(enemyCounts[0]);
            //Debug.Log(enemyCounts[1]);
            EnemyCount enemyCount = new EnemyCount(Convert.ToInt32(enemyCounts[0]), Convert.ToInt32(enemyCounts[1]));
            WaveList.Add(enemyCount);

        }
      
        
    
        //WaveList = new List<string>(waves);

        //foreach(string wave in WaveList)
        //{
        //    Debug.Log(wave);
        //}


            //foreach(string wave in waves)
            //{
            //    if(wave != null)
            //    {
            //        WaveList.Add(wave);
            //        Debug.Log(wave);
            //    }
            //}

    }

   


}
