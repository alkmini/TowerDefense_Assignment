// using NUnit.Framework;
// using UnityEngine;
// using Subscription = System.IDisposable;
//
// namespace UniReact.UnitTest
// {
// 	[TestFixture]
// 	public static class GameEvent_Test_Edit
// 	{
// 		[Test]
// 		public static void Unsubscribe_From_Event_On_Notify()
// 		{
// 			GameEvent gameEvent = ScriptableObject.CreateInstance<GameEvent>();
// 			int a = 0;
// 			gameEvent.Subscribe(() => { a = 1; });
// 			Subscription eventSubscription = null;
// 			eventSubscription = gameEvent.Subscribe(() => { eventSubscription.Dispose(); });
// 			gameEvent.Subscribe(() => { a = 2; });
// 			gameEvent.OnNext();
// 			Assert.AreEqual(2, a);
// 		}
// 	}
// }