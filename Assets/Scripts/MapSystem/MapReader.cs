using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapReader : MonoBehaviour
{
    [SerializeField]


    //[SerializeField]
    //[SerializeField]
    //[SerializeField]
    //[SerializeField]
    //[SerializeField]
    //[SerializeField]
    //[SerializeField]
    //[SerializeField]

    static void ReadText()
    {
        string path = "Assets/Resources/test.txt";
        path.ToString();
    }

    private LevelManager mapBuilder;

    private void Awake()
    {
        mapBuilder = GetComponent<LevelManager>();

        mapBuilder.CreateLevel();
    }
}


