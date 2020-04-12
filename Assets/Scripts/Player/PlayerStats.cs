using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    GameManager gameManager = null;

    [System.NonSerialized]
    public int Lives;

    public int startLives = 20;

    private void Awake()
    {
        Lives = startLives;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void ResetLives()
    {
        Lives = startLives;
    }
}
