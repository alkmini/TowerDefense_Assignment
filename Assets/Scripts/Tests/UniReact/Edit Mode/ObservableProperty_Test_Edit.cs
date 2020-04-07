// using System;
// using NUnit.Framework;
//
// namespace UniReact.UnitTest
// {
// 	[TestFixture]
// 	public partial class ObservableProperty_Test_Edit
// 	{
// 		[Test]
// 		public static void Subscribe_Remove_On_Loop_Forward() 
// 		{
// 			ObservableProperty<int> rp = new ObservableProperty<int>();
// 			int a = 0;
//
// 			IDisposable subscription = null;
//
// 			rp.Subscribe((a_int) => 
// 			{
// 				a = a_int;
// 				subscription.Dispose();
// 			});
// 			subscription = rp.Subscribe((a_int) => a = a_int + 1);
// 			rp.Subscribe((a_int) => a = a_int + 2);
//
// 			rp.Value = 0;
//
// 			Assert.AreEqual(2, a);
// 		}
// 	}
// }