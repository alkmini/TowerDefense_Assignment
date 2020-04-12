using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemy : MonoBehaviour
{
    public GameObject rootObject = null;
    [System.NonSerialized] public float health;
    [System.NonSerialized] public float damage;
    public virtual void TakeDamage(float amount)
    {
        health -= amount;
    }
   
}
