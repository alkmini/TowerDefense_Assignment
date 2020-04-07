using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] MapManager mapManager;
    [SerializeField] GameObject prefab;
    [SerializeField] float spawnTime;

    Vector3 _vec3Start;

    private float spawnTimer=0;

    private void Start()
    {
        _vec3Start = new Vector3 (mapManager.start.x * 2.0f, 0.8f, mapManager.start.y * 2.0f);
    }

    private void Update()
    {
        if (spawnTimer>=spawnTime)
        {
            Instantiate(prefab, _vec3Start, Quaternion.identity);
            spawnTimer -= spawnTime;
        }
        spawnTimer += Time.deltaTime;
    }

}
