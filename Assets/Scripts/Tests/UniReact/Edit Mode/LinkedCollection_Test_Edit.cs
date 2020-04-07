//-----------------------------------------------------------------------------------------------------------
// @Author => Ederic Polo 
// Contact => ederic.polo@gmail.com
//-----------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using NUnit.Framework;
using UniReact;

// [Serializable]
// public class DisposableProxy : IDisposable
// {
// 	private IDisposable m_Inner;
//
// 	public DisposableProxy(IDisposable inner)
// 	{
// 		m_Inner = inner;
// 	}
//
// 	public void Dispose()
// 	{
// 		m_Inner.Dispose();
// 		m_Inner = Disposable.Empty;
// 	}
// }
//
// namespace UniReact.UnitTest
// {
// 	[TestFixture]
// 	public class LinkedCollection_Test_Edit
// 	{
// 		[Test]
// 		public static void Manual_Enumeration()
// 		{
// 			var collection = new LinkedCollection<int>();
// 			collection.Add(1);
// 			IDisposable disposable = collection.Add(2);
// 			collection.Add(3);
//
// 			IEnumerator<int> enumerator = collection.GetEnumerator();
// 			int value = 0;
//
// 			while (enumerator.MoveNext())
// 			{
// 				value = enumerator.Current;
// 				disposable.Dispose();
// 			}
// 			Assert.AreEqual(3, value);
// 		}
// 		
// 		[Test]
// 		public static void Add_One_Element()
// 		{
// 			var collection = new LinkedCollection<int> {10};
// 			var values     = new List<int>();
// 			foreach (int value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(values.Count, 1);
// 			Assert.AreEqual(values[0],    10);
// 		}
//
// 		[Test]
// 		public static void Add_One_Element_Remove_Head()
// 		{
// 			var collection = new LinkedCollection<int>();
// 			var node       = collection.Add(10);
// 			node.Dispose();
// 			Assert.AreEqual(collection.Count, 0);
// 		}
//
// 		[Test]
// 		public static void Add_Two_Elements()
// 		{
// 			var collection = new LinkedCollection<int> {10, 15};
// 			var values     = new List<int>();
// 			foreach (int value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(values[0], 10);
// 			Assert.AreEqual(values[1], 15);
// 		}
//
// 		[Test]
// 		public static void Add_Two_Elements_Remove_Head()
// 		{
// 			var collection = new LinkedCollection<int> {10};
// 			var node       = collection.Add(15);
// 			node.Dispose();
// 			var values = new List<int>();
// 			foreach (var value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(1,  values.Count);
// 			Assert.AreEqual(10, values[0]);
// 		}
//
// 		[Test]
// 		public static void Add_Two_Elements_Remove_Head_Then_Head()
// 		{
// 			var collection = new LinkedCollection<int>();
// 			var un00       = collection.Add(10);
// 			var un01       = collection.Add(15);
// 			un01.Dispose();
// 			un00.Dispose();
// 			var values = new List<int>();
// 			foreach (var value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(0, values.Count);
// 			Assert.AreEqual(0, collection.Count);
// 		}
//
// 		[Test]
// 		public static void Add_Two_Elements_Remove_Base()
// 		{
// 			var collection = new LinkedCollection<int>();
// 			var node       = collection.Add(10);
// 			collection.Add(15);
// 			node.Dispose();
// 			var values = new List<int>();
// 			foreach (int value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(1,            values.Count);
// 			Assert.AreEqual(values.Count, collection.Count);
// 			Assert.AreEqual(15,           values[0]);
// 		}
//
// 		[Test]
// 		public static void Add_Thee_Elements_Remove_Middle()
// 		{
// 			var collection = new LinkedCollection<int> {5};
// 			IDisposable middle = collection.Add(10);
// 			collection.Add(15);
// 			middle.Dispose();
// 			List<int> values = new List<int>();
// 			foreach (int value in collection)
// 			{
// 				values.Add(value);
// 			}
//
// 			Assert.AreEqual(values.Count, 2);
// 			Assert.AreEqual(values[0],    5);
// 			Assert.AreEqual(values[1],    15);
// 			Assert.IsTrue(values.Count == collection.Count);
// 		}
//
// 		[Test]
// 		public static void Add_Thee_Elements_Remove_Middle_And_Last_I()
// 		{
// 			LinkedCollection<Action> collection = new LinkedCollection<Action>();
// 			int a = -1;
// 			IDisposable last = null, middle = null;
// 			collection.Add(() => { });
// 			middle = collection.Add(() =>
// 			{
// 				middle.Dispose();
// 				last.Dispose();
// 			});
// 			last = collection.Add(() => { a = 1; });
//
// 			foreach (Action action in collection)
// 			{
// 				action();
// 			}
//
// 			Assert.AreEqual(-1, a);
// 		}
//
// 		[Test]
// 		public static void Add_Thee_Elements_Remove_Middle_And_Last_II()
// 		{
// 			LinkedCollection<Action> collection = new LinkedCollection<Action>();
// 			int a = -1;
// 			IDisposable last = null, middle = null;
// 			collection.Add(() => { });
// 			middle = collection.Add(() =>
// 				{
// 					last.Dispose();
// 					middle.Dispose();
// 				}
// 			);
// 			last = collection.Add(() => { a = 1; });
//
// 			foreach (Action action in collection)
// 			{
// 				action();
// 			}
//
// 			Assert.AreEqual(-1, a);
// 		}
//
// 		[Test]
// 		public static void Add_Thee_Elements_Remove_Middle_And_Last_III()
// 		{
// 			LinkedCollection<Action> collection = new LinkedCollection<Action>();
// 			int a = -1;
// 			IDisposable first = null, last = null;
// 			first = collection.Add(() =>
// 			{
// 				first.Dispose();
// 				last.Dispose();
// 			});
// 			last = collection.Add(() => { a = 1; });
//
// 			foreach (Action action in collection)
// 			{
// 				action();
// 			}
//
// 			Assert.AreEqual(-1, a);
// 		}
//
// 		[Test]
// 		public static void Clear_Looping()
// 		{
// 			var collection = new LinkedCollection<int> {0, 1, 2, 3, 4, 5, 6};
// 			foreach (var element in collection)
// 			{
// 				if (element == 2)
// 				{
// 					collection.Clear();
// 				}
// 			}
//
// 			Assert.AreEqual(0, collection.Count);
// 		}
//
// 		[Test]
// 		public static void Add_Five_Elements_Remove_One_Looping()
// 		{
// 			var collection = new LinkedCollection<int>();
// 			List<IDisposable> subscriptions = new List<IDisposable>();
// 			
// 			for (int index = 0; index < 5; index++)
// 			{
// 				IDisposable subscription = collection.Add(index);
// 				subscriptions.Add(subscription);
// 			}
//
// 			int i = 0;
// 			foreach (int element in collection)
// 			{
// 				if (i == 3)
// 				{
// 					subscriptions[element].Dispose();
// 				}
//
// 				i++;
// 			}
//
// 			Assert.AreEqual(5, i);
// 			Assert.AreEqual(4, collection.Count);
// 		}
//
// 		[Test]
// 		public static void Add_Elements_Remove_All_Looping()
// 		{
// 			LinkedCollection<int> collection = new LinkedCollection<int>();
// 			List<IDisposable> subscriptions = new List<IDisposable>();
// 			
// 			int count = 3;
// 			for (int index = 0; index < count; index++)
// 			{
// 				IDisposable subscription = collection.Add(index);
// 				subscriptions.Add(subscription);
// 			}
//
// 			int i = 0;
// 			foreach (int value in collection)
// 			{
// 				subscriptions[value].Dispose();
// 				i++;
// 			}
//
// 			Assert.AreEqual(collection.Count, 0);
// 			Assert.AreEqual(i, count);
// 		}
// 	}
// }