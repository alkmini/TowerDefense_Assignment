using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemy : AEnemy
{
    private void Awake()
    {
        health = 100;
    }

    void Update()
    {
        
    }

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
