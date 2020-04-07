// //-----------------------------------------------------------------------------------------------------------
// // @Author => Ederic Polo 
// // Contact => ederic.polo@gmail.com
// //-----------------------------------------------------------------------------------------------------------
//
// using NUnit.Framework;
//
// namespace UniReact.UnitTest
// {
// 	[TestFixture]
// 	public class LinkedArray_Test_Edit
// 	{
// 		[Test]
// 		public static void Remove_Looping_I()
// 		{
// 			var list = new LinkedArray<int> {1, 2, 3};
// 			int i    = 0;
// 			//it 0 => 2, 3, 0, 0
// 			//it 1 => 3, 0, 0, 0, 0
// 			//it 2 => 0, 0, 0, 0, 0, 0
// 			foreach (var value in list)
// 			{
// 				list.Remove(value);
// 				list.Add(0);
// 				list.Add(0);
// 				i++;
// 				if (i == 3)
// 				{
// 					break;
// 				}
// 			}
//
// 			Assert.AreEqual(6, list.Count);
// 		}
//
// 		[Test]
// 		public static void Remove_Looping_II()
// 		{
// 			var list = new LinkedArray<int> {1, 2, 3};
// 			int i    = 0;
// 			int sum  = 0;
// 			// 0 => Sum = 1 + 1 = 2
// 			// 1 => Sum = 1 + 2 = 3 + [02] = 5  => [Remove 2]
// 			// 2 => Sum = 1 + 3 = 4 + [05] = 9  => [Jump 2 because it doesn't exist anymore]
// 			// 3 => Sum = 3 + 1 = 4 + [09] = 13 => [Jump 2 because it doesn't exist anymore]
// 			// 4 => Sum = 3 + 3 = 6 + [13] = 19
// 			foreach (var value0 in list)
// 			{
// 				foreach (var value1 in list)
// 				{
// 					sum += value0 + value1;
// 					if (i == 1)
// 					{
// 						list.Remove(2);
// 					}
//
// 					i++;
// 				}
// 			}
//
// 			Assert.AreEqual(2,  list.Count);
// 			Assert.AreEqual(19, sum);
// 		}
//
// 		[Test]
// 		public static void Remove_Looping_III()
// 		{
// 			var list = new LinkedArray<int> {1, 2, 3};
// 			int sum  = 0;
// 			foreach (var value0 in list)
// 			{
// 				foreach (var value1 in list)
// 				{
// 					list.Remove(1);
// 					list.Remove(2);
// 					list.Remove(3);
// 				}
// 			}
//
// 			Assert.AreEqual(0, list.Count);
// 			Assert.AreEqual(0, sum);
// 		}
//
// 		[Test]
// 		public static void Remove_Looping_IV()
// 		{
// 			var list = new LinkedArray<int> {1, 2, 3};
// 			int sum  = 0;
// 			foreach (var value0 in list)
// 			{
// 				foreach (var value1 in list)
// 				{
// 					list.RemoveAt(0);
// 					list.RemoveAt(1);
// 					list.RemoveAt(0);
// 				}
// 			}
//
// 			Assert.AreEqual(0, list.Count);
// 			Assert.AreEqual(0, sum);
// 		}
// 	}
// }