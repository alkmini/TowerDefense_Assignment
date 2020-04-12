using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;

public class BulletManager : MonoBehaviour
{
    public GameObject bulletPrefab;


    public GameObjectPool bulletPool;
    
    void Awake()
    {
        bulletPool = new GameObjectPool(100, bulletPrefab, 1, new GameObject("BulletParent").transform);
    }


}
