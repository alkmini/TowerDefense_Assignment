using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;

public class WeaponExample : MonoBehaviour
{
    [SerializeField] private GameObject m_BulletPrefab;
    private GameObjectPool m_BulletPool;
    private void Awake()
    {
        m_BulletPool = new GameObjectPool(10, m_BulletPrefab, 5, new GameObject("Bullet Parent").transform);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject bullet = m_BulletPool.Rent(false);
            BulletExample bulletComponent = bullet.GetComponent<BulletExample>();
            bullet.transform.position = transform.position;
            bulletComponent.Reset();
            bullet.SetActive(true);
            bulletComponent.Push();
        }
    }
}
