using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;

/// <summary>
/// It gives a direction to the bullet to hit the enemy.
/// It uses the Object pooling system to reuse the objects
/// </summary>
public class Bullet : MonoBehaviour
{
    #region Members
    
    //[HideInInspector]
    [System.NonSerialized]public Transform target = null;
    public GameObject particles = null;
 
    public float speed = 5f;
    #endregion Members

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
    /// <summary>
    /// It collides specifically with enemy and sets damage to it.
    /// It creates the explosion on the spot where it hit the enemy s collider.
    /// </summary>
    /// <param name="collision"> the object with which it collided with </param>
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
