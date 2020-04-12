using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// It Takes care of the player 's health and calls the EndGame function when the player runs out of lives
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField]public GameObject gameOverUI;
    public event Action onPlayerDeath;
    public static bool s_GameIsOver;

    [SerializeField] PlayerStats playerStats = null;
    private bool m_gameEnded = false;

    private void Start()
    {

        Time.timeScale = 1;
        s_GameIsOver = false;
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
        m_gameEnded = true;
        gameOverUI.SetActive(true);
    }
}
