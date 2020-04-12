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

    private void Start()
    {
        onPlayerDeath += EndGame;
    }



    void Update()
    {
        if (playerStats.Lives <= 0)
        {
            onPlayerDeath.Invoke();
            Time.timeScale = 0;
        }

    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("GameOver!");
    }
}
