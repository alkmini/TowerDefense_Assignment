using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// enemy that dies after 2 shots
/// </summary>
public class StandardEnemy : AEnemy
{
    private void Awake()
    {
        health = 100;
    }

    void Update()
    {
        
    }

    /// <summary>
    /// overrided function which was inherited by Abstract class AEnemy and sets the enemy's endurance.
    /// </summary>
    /// <param name="amount">This enemy takes 1/2 damage </param>
    public override void TakeDamage (float amount)
    {
        base.TakeDamage(amount);
        if (health <= 0)
        {
            health = 100f;
            rootObject.SetActive(false);

        }
    }
}
