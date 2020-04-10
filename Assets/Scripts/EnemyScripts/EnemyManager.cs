using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;
using AI;

[RequireComponent(typeof(EnemyWaves))]
public class EnemyManager : MonoBehaviour
{
   public EnemyWaves m_enemyWaves;
    Vector3 _vec3Start;
    [SerializeField] MapManager mapManager = null;
    public GameObject Type1;
    public GameObject Type2;

    private GameObjectPool m_EnemyPool;
    [SerializeField] GameObject Prefab = null;
    

    private void Awake()
    { 
        m_EnemyPool = new GameObjectPool(25, Prefab,1, new GameObject("Enemy Parent").transform);
        _vec3Start = new Vector3(mapManager.start.x * 2.0f, 0.8f, mapManager.start.y * 2.0f);
        if (m_enemyWaves == null)
        {
            m_enemyWaves = GetComponent<EnemyWaves>();
        }
        m_enemyWaves.PrepareWaves();
        StartCoroutine("SpawnTypes");
        
    }



    IEnumerator SpawnTypes()
    {

        for (int waveCounter = 0; waveCounter < m_enemyWaves.WaveList.Count; waveCounter++)
        {
            for (int type1Counter = 0; type1Counter < m_enemyWaves.WaveList[waveCounter].Type1; type1Counter++)
            {
                GameObject enemy = m_EnemyPool.Rent(false);
                enemy.transform.position = _vec3Start;
                enemy.GetComponent<DjikstraMovement>().ResetMovement();
                enemy.SetActive(true);
                yield return new WaitForSeconds(1);
            }
            for (int type2Counter = 0; type2Counter < m_enemyWaves.WaveList[waveCounter].Type2; type2Counter++)
            {
                Instantiate(Type2, _vec3Start, Quaternion.identity);
                yield return new WaitForSeconds(2);
            }
            Debug.Log("Hello");
            yield return new WaitForSeconds(3);
        }
      
    }

}
