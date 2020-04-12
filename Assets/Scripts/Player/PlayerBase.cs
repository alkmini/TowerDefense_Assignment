using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerBase : MonoBehaviour
{
    [SerializeField]
    PlayerStats playerStats = null;
   

    private void Awake()
    {
        playerStats.ResetLives();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ended");
        EndPath();
    }

    

    void EndPath()
    {
         playerStats.Lives--;
//         if (playerStats.Lives <= 0)
//         {
//             Time.timeScale = 0;
//         }

    }

}
