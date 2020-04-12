using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This script sits on the PlayerBase and it primarily decreases the player s health.
/// </summary>
public class PlayerBase : MonoBehaviour
{
    [SerializeField] private PlayerStats m_PlayerStats = null;
   

    private void Awake()
    {
        m_PlayerStats.ResetLives();
    }

    private void OnTriggerEnter(Collider other)
    {
        EndPath();
    }

    

    void EndPath()
    {
        m_PlayerStats.Lives--;
    }

}
