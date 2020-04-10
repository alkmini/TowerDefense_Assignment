using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public interface IPool<T>
    {
        T Rent(bool returnActive);
    }

    //that s a consctroctor. and we ned to provide some settings
    public class GameObjectPool : IPool<GameObject>
    {
        private uint m_InitSize;
        private readonly uint m_ExpandBy;
        private readonly GameObject m_Prefab;
        private readonly Transform m_Parent;

        //that s like a list
        readonly Stack<GameObject> m_Objects = new Stack<GameObject>();

        //that s the constructor
        public GameObjectPool(uint initSize, GameObject prefab, uint expandBy = 1, Transform parent = null)
        {
            //clamped otherwise it will create infinite loops if put 0
            m_ExpandBy = expandBy;
            m_Prefab = prefab;
            m_Parent = parent;
            m_Prefab.SetActive(false);
            Expand(initSize);
        }

        private void Expand(uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                GameObject instance = GameObject.Instantiate(m_Prefab, m_Parent);
                EmitOnDisable emitOnDisable = instance.AddComponent<EmitOnDisable>();
                emitOnDisable.OnDisableGameObject += UnRent;
                m_Objects.Push(instance);
            }
        }

        private void UnRent(GameObject gameObject)
        {
            m_Objects.Push(gameObject);
        }

        public GameObject Rent(bool returnActive)
        {
            if (m_Objects.Count == 0)
            {
                Expand(m_ExpandBy);

            }
            GameObject instance = m_Objects.Pop();

            instance.SetActive(returnActive);
            return instance;
        }
    }
}