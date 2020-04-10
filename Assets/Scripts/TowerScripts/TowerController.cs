using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI;


public class TowerController : MonoBehaviour
{
    GameObject target = null;
    private void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
        }
        else
        {
            transform.rotation = default;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funkar");
        if (other.transform.CompareTag("Enemy"))
        {
            target = other.gameObject;  //sets the value
        }
    }

    private void OnTriggerExit(Collider other)
    {
        target = null;
    }

    private void Shoot()
    {
        //Clamp shooting
    }
}
