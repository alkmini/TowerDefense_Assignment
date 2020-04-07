using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
//using UniReact.Pooling;

namespace Tests
{
    public class GameObjectPool_Play_Mode_Test
    {
    //     [UnityTest]
    //     [TestCase(/*size*/  1, /*expandBY*/(uint)1, /*Result = */ 1, ExpectedResult = null)]
    //     [TestCase(/*size*/  2, /*expandBY*/(uint)1, /*Result = */ 2, ExpectedResult = null)]
    //     [TestCase(/*size*/  0, /*expandBY*/(uint)1, /*Result = */ 0, ExpectedResult = null)]
    //     [TestCase(/*size*/ -1, /*expandBY*/(uint)1, /*Result = */ 0, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements(int initSize, uint expandBy, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Stored);
    //     }
    //     
    //     [UnityTest]
    //     [TestCase(/*size*/  1, /*expandBY*/ 1, /*Result = */ 1, ExpectedResult = null)]
    //     [TestCase(/*size*/  2, /*expandBY*/ 1, /*Result = */ 2, ExpectedResult = null)]
    //     [TestCase(/*size*/ -1, /*expandBY*/ 1, /*Result = */ 0, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements_Non_Spawn(int initSize, uint expandBy, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Created);
    //     }
    //     
    //     [UnityTest]
    //     [TestCase(/*size*/ 1, /*expandBy*/ 4, /*expResult[Stored] =*/ 3, ExpectedResult = null)]
    //     [TestCase(/*size*/ 2, /*expandBy*/ 5, /*expResult[Stored] =*/ 4, ExpectedResult = null)]
    //     [TestCase(/*size*/ 1, /*expandBy*/ 1, /*expResult[Stored] =*/ 0, ExpectedResult = null)]
    //     [TestCase(/*size*/ 0, /*expandBy*/ 1, /*expResult[Stored] =*/ 0, ExpectedResult = null)]
    //     [TestCase(/*size*/-1, /*expandBy*/ 1, /*expResult[Stored] =*/ 0, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements_And_Expand_Stored(int initSize, uint expandBy, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         for(int i = 0; i <= initSize; i++) 
    //         {
    //             gameObjectPool.Spawn();
    //         }
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Stored);
    //     }
    //     
    //     [UnityTest]
    //     [TestCase(/*size*/ 1, /*expandBy*/ 4, /*spawnAmount*/ 2, /*despawnAmount*/ 2, /*Result = */ 1, ExpectedResult = null)]
    //     [TestCase(/*size*/ 2, /*expandBy*/ 5, /*spawnAmount*/ 2, /*despawnAmount*/ 2, /*Result = */ 2, ExpectedResult = null)]
    //     [TestCase(/*size*/ 1, /*expandBy*/ 1, /*spawnAmount*/ 2, /*despawnAmount*/ 2, /*Result = */ 1, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements_And_Expand_And_Despawn_Stored(int initSize, uint expandBy, int spawnAmount, int despawnAmount, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         IList<GameObject> gameObjects = new List<GameObject>();
    //         
    //         for(int i = 0; i < initSize; i++) 
    //         {
    //              GameObject gameObject = gameObjectPool.Spawn();
    //              gameObjects.Add(gameObject);
    //         }
    //
    //         for (int i = 0; i <= Math.Min(gameObjects.Count - 1, despawnAmount); i++) 
    //         {
    //             gameObjects[i].SetActive(false);
    //         }
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Stored);
    //     }
    //     
    //     [UnityTest]
    //     [TestCase(/*size*/1, /*expandBy*/4, /*spawnAmount*/2, /*Result = */5, ExpectedResult = null)]
    //     [TestCase(/*size*/2, /*expandBy*/5, /*spawnAmount*/2, /*Result = */2, ExpectedResult = null)]
    //     [TestCase(/*size*/1, /*expandBy*/1, /*spawnAmount*/2, /*Result = */2, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements_And_Expand_Created(int initSize, uint expandBy, int spawnAmount, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         
    //         for(int i = 0; i < spawnAmount; i++) 
    //         {
    //             gameObjectPool.Spawn();
    //         }
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Created);
    //     }
    //     
    //     [UnityTest]
    //     [TestCase(/*size*/1, /*expandBy*/4, /*spawnAmount*/2, /*despawnAmount*/2, /*Result = */5, ExpectedResult = null)]
    //     [TestCase(/*size*/2, /*expandBy*/5, /*spawnAmount*/2, /*despawnAmount*/2, /*Result = */2, ExpectedResult = null)]
    //     [TestCase(/*size*/1, /*expandBy*/1, /*spawnAmount*/2, /*despawnAmount*/2, /*Result = */2, ExpectedResult = null)]
    //     public IEnumerator Pool_Create_With_Elements_And_Expand_And_Despawn_Created(int initSize, uint expandBy, int spawnAmount, int despawnAmount, int expectedResult)
    //     {
    //         var policy = new LinearExpandPolicy(expandBy);
    //         GameObjectPool gameObjectPool = new GameObjectPool(new GameObject(), policy, initSize, new RectTransform());
    //         
    //         IList<GameObject> gameObjects    = new List<GameObject>();
    //         for(int i = 0; i < spawnAmount; i++) 
    //         {
    //             GameObject gameObject = gameObjectPool.Spawn();
    //             gameObjects.Add(gameObject);
    //         }
    //
    //         for (int i = 0; i <= Math.Min(gameObjects.Count - 1, despawnAmount); i++) 
    //         {
    //             gameObjects[i].SetActive(false);
    //         }
    //         
    //         yield return null;
    //         Assert.AreEqual(expectedResult, gameObjectPool.Created);
    //     }
    }
}
