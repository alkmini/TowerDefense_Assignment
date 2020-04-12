using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : AEnemy
{


    private void Awake()
    {
        health = 200f;
    }

    public override void TakeDamage(float amount)
    {
        base.TakeDamage(amount);
        if (health <= 0)
        {
            rootObject.SetActive(false);
        }
    }

}
