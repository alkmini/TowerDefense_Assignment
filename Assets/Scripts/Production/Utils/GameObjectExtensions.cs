using UnityEngine;

namespace Tools
{
    public static partial class GameObjectExtensions 
    {
        public static T ForceComponent<T>(this GameObject gameObject) where T : Component 
        {
            T component = gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
            return component;
        }
    }    
}