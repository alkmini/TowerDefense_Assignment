using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a scriptable object. It holds the player s lives and is controlled by the gameManager.
/// </summary>
[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    private GameManager gameManager = null;

    [System.NonSerialized] public int Lives;

    public int startLives = 20;

    private void Awake()
    { 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    /// <summary>
    /// It Resets the lives of the player after it reaches zero and the game ended.
    /// </summary>
    public void ResetLives()
    {
        Lives = startLives;
    }
}
