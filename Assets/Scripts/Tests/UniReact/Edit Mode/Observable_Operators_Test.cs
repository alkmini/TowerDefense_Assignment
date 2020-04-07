//-----------------------------------------------------------------------------------------------------------
// @Author => Ederic Polo 
// Contact => ederic.polo@gmail.com
//-----------------------------------------------------------------------------------------------------------

using System;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace UniReact.UnitTest
{
	[TestFixture]
	public static class Observable_Operators_Test
	{
		// [Test]
		// public static void Subscribe_Remove_On_Loop_Backward() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int a = 0;
		//
		// 	IDisposable subscription = null;
		//
		// 	subscription = rp.Subscribe((num) => { });
		// 	rp.Subscribe((num) => {
		// 		if (subscription != null) {
		// 			subscription.Dispose();
		// 			subscription = null;
		// 		}
		// 	});
		// 	rp.Subscribe((num) => a = num + 5);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 5;
		//
		// 	Assert.AreEqual(10, a);
		// }
		//
		// [Test]
		// public static void Operator_Buffer_Elements_OnTime() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	IList<int> values = null;
		//
		// 	Action<IList<int>> BufferCallback = (value) => {
		// 		values = value;
		// 	};
		//
		// 	rp.Buffer(2, TimeSpan.FromMilliseconds(200), BufferTimeFilter.OnRange).
		// 	   Subscribe(BufferCallback);
		//
		// 	rp.Value = 0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.15f));
		// 	rp.Value = 5;
		//
		// 	Assert.AreEqual(0, values[0]);
		// 	Assert.AreEqual(5, values[1]);
		// }
		//
		// [Test]
		// public static void Operator_Buffer_Elements_OutTime()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	IList<int> values = null;
		//
		// 	Action<IList<int>> BufferCallback = (value) =>{
		// 		values = value;
		// 	};
		//
		// 	rp.Buffer(2, TimeSpan.FromMilliseconds(200), BufferTimeFilter.OnRange).Subscribe(BufferCallback);
		//
		// 	rp.Value = 0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.25f));
		// 	rp.Value = 5;
		//
		// 	Assert.AreEqual(null, values);
		// }
		//
		// [Test]
		// public static void Operator_Buffer_Elements_Alternate_OnTime()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	IList<int> values = null;
		//
		// 	Action<IList<int>> BufferCallback = (value) =>{
		// 		values = value;
		// 	};
		//
		//
		// 	rp.Buffer(2, TimeSpan.FromMilliseconds(200), BufferTimeFilter.OnRange).
		// 		Subscribe(BufferCallback);
		//
		// 	rp.Value = 0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.25f));
		// 	rp.Value = 5;
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.15f));
		// 	rp.Value = 10;
		//
		// 	Assert.AreEqual(5, values[0]);
		// 	Assert.AreEqual(10, values[1]);
		// }
		//
		// [Test]
		// public static void Operator_Buffer_Elements_Alternate_OnTime_Time_Filter_On_Range() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	IList<int> values = null;
		//
		// 	Action<IList<int>> BufferCallback = (value) =>{
		// 		values = value;
		// 	};
		//
		//
		// 	rp.Buffer(2).
		// 	   TimeWindow(TimeSpan.FromMilliseconds(200), TimeFilter.OnRange).
		// 	   Subscribe(BufferCallback);
		//
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.25f));
		// 	rp.Value = 0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.25f));
		// 	rp.Value = 5;
		// 	rp.Value = 10;
		// 	rp.Value = 15;
		//
		// 	Assert.IsNotNull(values);
		// 	Assert.AreEqual(10, values[0]);
		// 	Assert.AreEqual(15, values[1]);
		// }
		//
		// [Test]
		// public static void Operator_Buffer_Elements_Alternate_OnTime_Time_Filter_Out_Range()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	IList<int> values = null;
		//
		// 	Action<IList<int>> BufferCallback = (value) => {
		// 		values = value;
		// 	};
		//
		// 	rp.Buffer(2).
		// 	   TimeWindow(TimeSpan.FromMilliseconds(200), TimeFilter.OutOfRange).
		// 	   Subscribe(BufferCallback);
		//
		// 	Thread.Sleep(TimeSpan.FromSeconds(0.25f));
		// 	rp.Value = 0;
		// 	rp.Value = 5;
		// 	rp.Value = 10;
		// 	rp.Value = 15;
		//
		// 	Assert.IsNotNull(values);
		// 	Assert.AreEqual(0, values[0]);
		// 	Assert.AreEqual(5, values[1]);
		// }
		//
		// [Test]
		// public static void Operator_Where() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int? values = null;
		//
		// 	Action<int> Callback = (value) => {
		// 		values = value;
		// 	};
		//
		// 	rp.Where(a_value=> a_value > 10).Subscribe(Callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 5;
		// 	rp.Value = 10;
		// 	rp.Value = 15;
		//
		// 	Assert.IsNotNull(values);
		// 	Assert.AreEqual(15, values.Value);
		// }
		//
		// [Test]
		// public static void Operator_Map() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	string playerAge = null;
		//
		// 	Action<string> callback = (a_value) => {
		// 		playerAge = a_value;
		// 	};
		//
		// 	rp.Map(a_value => "Player age is " + a_value ).Subscribe(callback);
		//
		// 	rp.Value = 15;
		// 	
		// 	Assert.AreEqual("Player age is 15", playerAge);
		// }
		//
		// [Test]
		// public static void Operator_Skip() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.Skip(3).Subscribe(callback);
		//
		// 	rp.Value = 1;
		// 	rp.Value = 2;
		// 	rp.Value = 3;
		// 	rp.Value = 4;
		// 	rp.Value = 5;
		//
		// 	Assert.AreEqual(9, result);
		// }
		//
		// [Test]
		// public static void Operator_SkipWhile()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.SkipWhile(a_value=> a_value < 0).Subscribe(callback);
		//
		// 	rp.Value = - 3;
		// 	rp.Value = - 1;
		// 	rp.Value =   0;
		// 	rp.Value =   1;
		// 	rp.Value = -10;
		// 	rp.Value = -2;
		//
		// 	Assert.AreEqual(-11, result);
		// }
		//
		// [Test]
		// public static void Operator_SkipWhileTime() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	DateTime time = DateTime.Now;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.SkipWhile(a_value => DateTime.Now  - time < TimeSpan.FromSeconds(1)).Subscribe(callback);
		//
		// 	rp.Value =  -3;
		// 	rp.Value =  -1;
		// 	rp.Value =   0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(1));
		// 	rp.Value =   1;
		// 	rp.Value = -10;
		// 	rp.Value =  -2;
		//
		// 	Assert.AreEqual(-11, result);
		// }
		//
		// [Test]
		// public static void Operator_SkipUntil() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.SkipUntil(a_value => a_value >= 0).Subscribe(callback);
		//
		// 	rp.Value = -3;
		// 	rp.Value = -1;
		// 	rp.Value = 0;
		// 	rp.Value = 1;
		// 	rp.Value = -10;
		// 	rp.Value = -2;
		//
		// 	Assert.AreEqual(-11, result);
		// }
		//
		// [Test]
		// public static void Operator_Take() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.Take(3).Subscribe(callback);
		//
		// 	rp.Value = -1;
		// 	rp.Value = 2;
		// 	rp.Value = 1;
		// 	rp.Value = 4;
		// 	rp.Value = 15;
		//
		// 	Assert.AreEqual(2, result);
		// }
		//
		// [Test]
		// public static void Operator_TakeWhile() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.TakeWhile(a_value=> a_value < 0 ).Subscribe(callback);
		//
		// 	rp.Value =  -1;
		// 	rp.Value =  -2;
		// 	rp.Value = -20;
		// 	rp.Value =   1;
		// 	rp.Value =  -4;
		// 	rp.Value = -15;
		//
		// 	Assert.AreEqual(-23, result);
		// }
		//
		// [Test]
		// public static void Operator_TakeWhileTime() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	DateTime time = DateTime.Now;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.TakeWhile(a_value => DateTime.Now - time < TimeSpan.FromSeconds(1)).Subscribe(callback);
		//
		// 	rp.Value = -3;
		// 	rp.Value = -1;
		// 	rp.Value = 0;
		// 	Thread.Sleep(TimeSpan.FromSeconds(1));
		// 	rp.Value = 1;
		// 	rp.Value = -10;
		// 	rp.Value = -2;
		//
		// 	Assert.AreEqual(-4, result);
		// }
		//
		// [Test]
		// public static void Operator_TakeUntil() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result += a_value;
		// 	};
		//
		// 	rp.TakeUntil(a_value => a_value >= 0).Subscribe(callback);
		//
		// 	rp.Value = -1;
		// 	rp.Value = -2;
		// 	rp.Value = -20;
		// 	rp.Value = 1;
		// 	rp.Value = -4;
		// 	rp.Value = -15;
		//
		// 	Assert.AreEqual(-23, result);
		// }
		//
		// [Test]
		// public static void Operator_Max() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result = a_value;
		// 	};
		//
		// 	rp.Max().Subscribe(callback);
		//
		// 	rp.Value = -1;
		// 	rp.Value = 2;
		// 	rp.Value = 15;
		// 	rp.Value = 1;
		// 	rp.Value = 4;
		//
		// 	Assert.AreEqual(15, result);
		// }
		//
		// [Test]
		// public static void Operator_Min() 
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	int result = 0;
		//
		// 	Action<int> callback = (a_value) => {
		// 		result = a_value;
		// 	};
		//
		// 	rp.Min().Subscribe(callback);
		// 	
		// 	rp.Value = 2;
		// 	rp.Value = 15;
		// 	rp.Value = -1;
		// 	rp.Value = 1;
		// 	rp.Value = 4;
		//
		// 	Assert.AreEqual(-1, result);
		// }
		//
		// [Test]
		// public static void Operator_IntAverage()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	List<double> result = new List<double>(3);
		//
		// 	Action<double> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Average().Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 10;
		// 	rp.Value = 20;
		//
		// 	Assert.AreEqual(0d,  result[0]);
		// 	Assert.AreEqual(5d,  result[1]);
		// 	Assert.AreEqual(10d, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_FloatAverage()
		// {
		// 	ObservableProperty<float> rp = new ObservableProperty<float>();
		//
		// 	List<double> result = new List<double>(3);
		//
		// 	Action<double> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Average().Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 15f;
		// 	rp.Value = 30f;
		//
		// 	Assert.AreEqual(0f, result[0]);
		// 	Assert.AreEqual(7.5f, result[1]);
		// 	Assert.AreEqual(15f, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_DoubleAverage() {
		// 	ObservableProperty<double> rp = new ObservableProperty<double>();
		//
		// 	List<double> result = new List<double>(3);
		//
		// 	Action<double> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Average().Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 15f;
		// 	rp.Value = 30f;
		//
		// 	Assert.AreEqual(  0d, result[0]);
		// 	Assert.AreEqual(7.5d, result[1]);
		// 	Assert.AreEqual( 15d, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_IntSum()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	List<int> result = new List<int>(3);
		//
		// 	Action<int> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Sum().Map(a_sum=>(int)a_sum).Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 10;
		// 	rp.Value = 20;
		//
		// 	Assert.AreEqual(0, result[0]);
		// 	Assert.AreEqual(10, result[1]);
		// 	Assert.AreEqual(30, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_FloatSum()
		// {
		// 	ObservableProperty<float> rp = new ObservableProperty<float>();
		//
		// 	List<float> result = new List<float>(3);
		//
		// 	Action<float> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Sum().Map(a_sum=> (float)a_sum).Subscribe(callback);
		//
		// 	rp.Value =  0;
		// 	rp.Value = -1.5f;
		// 	rp.Value = 2.5f;
		//
		// 	Assert.AreEqual(0f,  result[0]);
		// 	Assert.AreEqual(-1.5f, result[1]);
		// 	Assert.AreEqual(1f, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_DoubleSum()
		// {
		// 	ObservableProperty<double> rp = new ObservableProperty<double>();
		//
		// 	List<double> result = new List<double>(3);
		//
		// 	Action<double> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Sum().Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = -1.5d;
		// 	rp.Value = 2.5d;
		//
		// 	Assert.AreEqual(0f, result[0]);
		// 	Assert.AreEqual(-1.5d, result[1]);
		// 	Assert.AreEqual(1d, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_IntSub()
		// {
		// 	ObservableProperty<int> rp = new ObservableProperty<int>();
		//
		// 	List<int> result = new List<int>(3);
		//
		// 	Action<int> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Subtraction().Map(a_sum => (int)a_sum).Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = 10;
		// 	rp.Value = 20;
		//
		// 	Assert.AreEqual(0, result[0]);
		// 	Assert.AreEqual(-10, result[1]);
		// 	Assert.AreEqual(-30, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_FloatSub()
		// {
		// 	ObservableProperty<float> rp = new ObservableProperty<float>();
		//
		// 	List<float> result = new List<float>(3);
		//
		// 	Action<float> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Subtraction().Map(a_sum => (float)a_sum).Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = -1.5f;
		// 	rp.Value = 2.5f;
		//
		// 	Assert.AreEqual(0f, result[0]);
		// 	Assert.AreEqual(1.5f, result[1]);
		// 	Assert.AreEqual(-1f, result[2]);
		// }
		//
		// [Test]
		// public static void Operator_DoubleSub()
		// {
		// 	ObservableProperty<double> rp = new ObservableProperty<double>();
		//
		// 	List<double> result = new List<double>(3);
		//
		// 	Action<double> callback = (a_value) => {
		// 		result.Add(a_value);
		// 	};
		//
		// 	rp.Subtraction().Subscribe(callback);
		//
		// 	rp.Value = 0;
		// 	rp.Value = -1.5d;
		// 	rp.Value = 2.5d;
		//
		// 	Assert.AreEqual(0f, result[0]);
		// 	Assert.AreEqual(1.5d, result[1]);
		// 	Assert.AreEqual(-1d, result[2]);
		// }
	}
}