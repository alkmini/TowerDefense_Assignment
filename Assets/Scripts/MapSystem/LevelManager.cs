using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{
    //[SerializeField] private TileMethods tileMethods;

    public void CreateLevel()
    {
        string[] mapData = ReadLevelText(); /*= new string[]
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "9"
        };*/

        for (int i = 0; i < mapData.Length; i++)
        {
            Debug.Log(mapData[i]);
        }
        Debug.Log("Hej");

    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("test") as TextAsset;

        string data = bindData.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('\n');
    }
}
