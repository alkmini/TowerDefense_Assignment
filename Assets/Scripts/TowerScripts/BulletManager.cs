using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;

public class BulletManager : MonoBehaviour
{
    public GameObject BulletPrefab;


    public GameObjectPool m_BulletPool;
    
    void Awake()
    {
        m_BulletPool = new GameObjectPool(100, BulletPrefab, 1, new GameObject("BulletParent").transform);
    }


}
