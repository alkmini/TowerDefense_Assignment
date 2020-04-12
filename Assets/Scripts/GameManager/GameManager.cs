using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action onPlayerDeath;

    [SerializeField]
    PlayerStats playerStats = null;

    private bool gameEnded = false;

    void Update()
    {
        if (playerStats.Lives <= 0)
        {
            EndGame();
            Time.timeScale = 0;
        }

    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("GameOver!");
    }
}
