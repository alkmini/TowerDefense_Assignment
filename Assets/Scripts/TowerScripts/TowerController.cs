using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI;
using Tools;



public class TowerController : MonoBehaviour
{
    [Header("Required variables")]
    public GameObject target = null;
    public Transform partToRotate = null;

    public GameObject bulletPrefab;
    public Transform firepoint;

    private GameObjectPool m_BulletPool = null;


    [Header("Attributes")]
    public float range = 0f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    private void Start()
    {
        m_BulletPool = GameObject.Find("BulletManager").GetComponent<BulletManager>().bulletPool;
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
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

        if (target == null) return;

        //Target lock on
        GameObject _target = GameObject.FindGameObjectWithTag("Enemy");
        if (_target == null) return;
        Vector3 TargetPos = _target.transform.position;
        Vector3 dir = TargetPos - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * 10f).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate; //time = 1/frequency

        }
        fireCountdown -= Time.deltaTime;
    }

    void UpdateTarget()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = (enemy.transform.position - gameObject.transform.position).magnitude;
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy;
        }
        else
        {
            target = null;
        }
    }


    private void Shoot()
    {
        
       
        GameObject bullet = m_BulletPool.Rent(false);
        bullet.transform.position = firepoint.transform.position;
        bullet.GetComponent<Bullet>().target = target.transform;
        bullet.SetActive(true);

    }
}
