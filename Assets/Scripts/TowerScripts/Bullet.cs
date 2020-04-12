using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;

public class Bullet : MonoBehaviour
{
    //[HideInInspector]
    [System.NonSerialized]public Transform target = null;
    public GameObject particles = null;
 
    public float speed = 5f;

    private void Update()
    {
        if (target == null || !target.gameObject.activeSelf )
        {
            gameObject.SetActive(false);
            Instantiate(particles, transform.position, Quaternion.identity);

        }
        Vector3 newPos = (target.position - transform.position).normalized * speed * Time.deltaTime;
        transform.position += newPos;

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (target != null && collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<AEnemy>().TakeDamage(50f);
            gameObject.SetActive(false);
            Instantiate(particles, transform.position, Quaternion.identity);
        }
    }


}
