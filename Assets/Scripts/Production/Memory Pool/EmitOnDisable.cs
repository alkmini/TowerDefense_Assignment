using UnityEngine;
using System;

namespace Tools
{
    public class EmitOnDisable : MonoBehaviour
    {
        public event Action<GameObject> OnDisableGameObject;

        private void OnDisable()
        {
            OnDisableGameObject?.Invoke(this.gameObject);
        }
    }
}
