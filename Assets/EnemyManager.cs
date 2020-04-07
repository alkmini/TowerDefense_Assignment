using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyPrefab;

    private static EnemyManager m_Instance;
    public static EnemyManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                EnemyManager[] managers = GameObject.FindObjectsOfType<EnemyManager>();
                m_Instance = new EnemyManager();

                if(managers.Length > 1)
                {
                    Debug.LogWarning("Only one instance of EnemyMasng must be placed in the scene");
                }

                if (managers.Length > 0)
                {
                    m_Instance = managers[0];
                }
                else {
                    GameObject obj = new GameObject();
                    m_Instance = obj.AddComponent<EnemyManager>();
                        }
            }
            return m_Instance;
        }
    }
}
