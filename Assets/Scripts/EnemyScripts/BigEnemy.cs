using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// enemy that dies after 4 shots.
/// This enemy does not use Object pooling system
/// </summary>
public class BigEnemy : AEnemy
{


    private void Awake()
    {
        health = 200f;
    }

    /// <summary>
    /// overrided function which was inherited by Abstract class AEnemy and sets the enemy's endurance.
    /// </summary>
    /// <param name="amount">This enemy takes 1/4 damage </param>
    public override void TakeDamage(float amount)
    {
        base.TakeDamage(amount);
        if (health <= 0)
        {
            health = 200f;
            rootObject.SetActive(false);
        }
    }

}
