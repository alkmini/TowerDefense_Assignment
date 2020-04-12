using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An abstract class for the enemy's general damage function that is inherited to each enemy and modified to their special properties.
/// </summary>
public abstract class AEnemy : MonoBehaviour
{
    public GameObject rootObject = null;
    [System.NonSerialized] public float health;
    [System.NonSerialized] public float damage;

    /// <summary>
    /// function that gets overrided in order to change the amount of damage to be taken
    /// </summary>
    /// <param name="amount">amount of damage to be taken</param>
    public virtual void TakeDamage(float amount)
    {
        health -= amount;
    }
   
}
