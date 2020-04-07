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
// 	public class FlexBuffer_Test
// 	{
// 		[Test]
// 		public static void Add_One_Element_Remove_One()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			array.Remove(1);
// 			Assert.AreEqual(array.Count, 0);
// 		}
//
// 		[Test]
// 		public static void Add_One_Element()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			Assert.AreEqual(array.Count, 1);
// 		}
//
// 		[Test]
// 		public static void Add_One_Element_Verify_Value()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			Assert.AreEqual(array[0], 1);
// 		}
//
// 		[Test]
// 		public static void Add_Two_Elements()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			array.Add(2);
// 			Assert.AreEqual(array.Count, 2);
// 			Assert.AreEqual(array[0],    1);
// 			Assert.AreEqual(array[1],    2);
// 		}
//
// 		[Test]
// 		public static void Add_Three_Elements_Remove_Middle()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			array.Add(2);
// 			array.Add(3);
// 			array.Remove(2);
// 			Assert.AreEqual(array.Count, 2);
// 			Assert.AreEqual(array[0],    1);
// 			Assert.AreEqual(array[1],    3);
// 		}
//
// 		[Test]
// 		public static void Add_Three_Elements_Remove_Middle_Add_Element()
// 		{
// 			FlexBuffer<int> array = new FlexBuffer<int>();
// 			array.Add(1);
// 			array.Add(2);
// 			array.Add(3);
// 			array.Remove(2);
// 			array.Add(2);
// 			Assert.AreEqual(array.Count, 3);
// 			Assert.AreEqual(array[0],    1);
// 			Assert.AreEqual(array[1],    3);
// 			Assert.AreEqual(array[2],    2);
// 		}
// 	}
// }