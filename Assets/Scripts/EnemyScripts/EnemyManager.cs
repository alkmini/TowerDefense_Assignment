using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tools;
using AI;

/// <summary>
/// It spawns the enemyWaves over time and uses IPool's system: object pooling for the standard enemy
/// </summary>
[RequireComponent(typeof(EnemyWaves))]
public class EnemyManager : MonoBehaviour
{
    #region Members
    public EnemyWaves enemyWaves;
    [SerializeField] MapManager mapManager = null;
    public GameObject enemyType1;
    public GameObject enemyType2;

    private GameObjectPool m_EnemyPool;
    private Vector3 m_Vec3Start;
    [SerializeField] private GameObject m_Prefab = null;
    #endregion Members


    private void Awake()
    { 
        m_EnemyPool = new GameObjectPool(25, m_Prefab,1, new GameObject("Enemy Parent").transform);
        m_Vec3Start = new Vector3(mapManager.start.x * 2.0f, 0.8f, mapManager.start.y * 2.0f);
        if (enemyWaves == null)
        {
            enemyWaves = GetComponent<EnemyWaves>();
        }
        enemyWaves.PrepareWaves();
        StartCoroutine("SpawnTypes");
    }



    IEnumerator SpawnTypes()
    {

        for (int waveCounter = 0; waveCounter < enemyWaves.WaveList.Count; waveCounter++)
        {
            for (int type1Counter = 0; type1Counter < enemyWaves.WaveList[waveCounter].enemyType1; type1Counter++)
            {
                GameObject enemy = m_EnemyPool.Rent(false);
                enemy.transform.position = m_Vec3Start;
                enemy.GetComponent<DjikstraMovement>().ResetMovement();
                enemy.SetActive(true);
                yield return new WaitForSeconds(1);
            }
            for (int type2Counter = 0; type2Counter < enemyWaves.WaveList[waveCounter].enemyType2; type2Counter++)
            {
                Instantiate(enemyType2, m_Vec3Start, Quaternion.identity);
                yield return new WaitForSeconds(2);
            }
            
            yield return new WaitForSeconds(3);
        }
      
    }

}
