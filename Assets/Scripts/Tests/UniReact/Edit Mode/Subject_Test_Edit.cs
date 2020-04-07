//-----------------------------------------------------------------------------------------------------------
// @Author => Ederic Polo 
// Contact => ederic.polo@gmail.com
//-----------------------------------------------------------------------------------------------------------

using System;
using NUnit.Framework;

namespace UniReact.UnitTest
{
	[TestFixture]
	public class Subject_Test_Edit
	{
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_I() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null;
		//
		// 	subject.Subscribe((_) => { });
		// 	middle = subject.Subscribe(
		// 		(_) => {
		// 			middle.Dispose();
		// 			last.  Dispose();
		// 		});
		// 	last = subject.Subscribe((_) => { a = 1; });
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(-1, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_II() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		//
		// 	first = observable.Subscribe((_) => {
		// 		first. Dispose();
		// 		middle.Dispose();
		// 		last.  Dispose();
		// 	});
		//
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; });
		//
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(-1, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_III() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		//
		// 	first = observable.Subscribe((_) => {
		// 		middle.Dispose();
		// 		last.  Dispose();
		// 		first. Dispose();
		// 	});
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; });
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(-1, a);
		// }
		//
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_IV() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		// 	first = observable.Subscribe((_) => {
		// 		last.  Dispose();
		// 		middle.Dispose();
		// 		first. Dispose();
		// 	});
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; });
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(-1, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_V() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		// 	observable.Subscribe((_) => { a++; });
		// 	first = observable.Subscribe((_) => {
		// 		last.  Dispose();
		// 		middle.Dispose();
		// 		first. Dispose();
		// 	});
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; }); 
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(0, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_VI() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		// 	first = observable.Subscribe((_) => {
		// 		last.  Dispose();
		// 		middle.Dispose();
		// 		first. Dispose();
		// 	});
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; });
		// 	observable.Subscribe((_) => { a++; });
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(0, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_VII() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = -1;
		// 	IDisposable last = null, middle = null, first = null;
		// 	observable.Subscribe((_) => { a++; });
		// 	first = observable.Subscribe((_) => {
		// 		last.Dispose();
		// 		middle.Dispose();
		// 		first.Dispose();
		// 	});
		// 	middle = observable.Subscribe((_) => { a++; });
		// 	last   = observable.Subscribe((_) => { a++; });
		// 	observable.Subscribe((_) => { a++; });
		// 	observable.OnNext(1);
		// 	Assert.AreEqual(1, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_VIII() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = 0;
		// 	IDisposable last = null, middle1 = null, middle0 = null, first = null;
		//
		// 	first   = observable.Subscribe((_) => { a++; });
		// 	middle0 = observable.Subscribe((_) => {
		// 		middle0.Dispose();
		// 		first.  Dispose();
		// 		middle1.Dispose();
		// 		last.   Dispose();
		// 	});
		// 	middle1 = observable.Subscribe((_) => { a++; });
		// 	last    = observable.Subscribe((_) => { a++; });
		// 	observable.Subscribe((_) => { a++; });
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe((_) => { a--;});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	Assert.AreEqual(2, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_VIV() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = 0;
		// 	IDisposable last = null, middle1 = null, middle0 = null, first = null;
		//
		// 	first   = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	middle0 = observable.Subscribe((_) => {
		// 		middle0.Dispose();
		// 		first.Dispose();
		// 		middle1.Dispose();
		// 		last.Dispose();
		// 		observable.Subscribe(
		// 			(__) => {
		// 				a++;
		// 			});
		// 	});
		// 	middle1 = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	last    = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	Assert.AreEqual(4, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_X() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int a = 0;
		// 	IDisposable last = null, middle1 = null, middle0 = null, first = null;
		//
		// 	first = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	middle0 = observable.Subscribe((_) => {
		// 		middle0.Dispose();
		// 		first.Dispose();
		// 		middle1.Dispose();
		// 		observable.Subscribe(
		// 			(__) => {
		// 				a++;
		// 			});
		// 		last.Dispose();
		// 	});
		//
		// 	middle1 = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	last = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	Assert.AreEqual(4, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XI() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int          a          = 0;
		// 	IDisposable  last       = null, middle1 = null, middle0 = null, first = null;
		//
		// 	first = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	middle0 = observable.Subscribe((_) => {
		// 		middle0.Dispose();
		// 		first.Dispose();
		// 		middle1.Dispose();
		// 		observable.Subscribe(
		// 			(__) => {
		// 				a++;
		// 				last.Dispose();
		// 			});
		// 	});
		//
		// 	middle1 = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	last = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	Assert.AreEqual(5, a);
		// }
		//
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XII() 
		// {
		// 	Subject<int> observable = new Subject<int>();
		// 	int          a          = 0;
		// 	IDisposable  last       = null, middle1 = null, middle0 = null, first = null;
		//
		// 	first = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	middle0 = observable.Subscribe((_) => {
		// 		middle0.Dispose();
		// 		first.Dispose();
		// 		middle1.Dispose();
		// 		observable.Subscribe(
		// 			(__) => {
		// 				a++;
		// 				last.Dispose();
		// 			});
		// 	});
		//
		// 	middle1 = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		// 	last = observable.Subscribe(
		// 		(_) => {
		// 			a++;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.Subscribe(
		// 		(_) => {
		// 			a--;
		// 		});
		//
		// 	observable.OnNext(int.MaxValue);
		//
		// 	Assert.AreEqual(4, a);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XIII() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable = null;
		// 	Action<int> act0 = (_) => { disposable.Dispose(); };
		// 	Action<int> act1 = (_) => { value++; };
		// 	Action<int> act2 = (_) => { value++; };
		//
		// 	disposable = subject.Subscribe(act0);
		// 	subject.Subscribe(act1);
		// 	subject.Subscribe(act2);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(2, value);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XIV() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable = null;
		// 	Action<int> act0 = (_) => { disposable.Dispose(); };
		// 	Action<int> act1 = (_) => { value++; };
		// 	Action<int> act2 = (_) => { value++; };
		//
		// 	subject.Subscribe(act0);
		// 	disposable = subject.Subscribe(act1);
		// 	subject.Subscribe(act2);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(1, value);
		// }
		//
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XV() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable = null;
		// 	Action<int> act0 = (_) => { value++; };
		// 	Action<int> act1 = (_) => { disposable.Dispose(); };
		// 	Action<int> act2 = (_) => { value++; };
		//
		// 	subject.Subscribe(act0);
		// 	disposable = subject.Subscribe(act1);
		// 	subject.Subscribe(act2);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(2, value);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XVI() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable = null;
		// 	Action<int> act0 = (_) => { disposable.Dispose(); };
		// 	Action<int> act1 = (_) => { value++; };
		// 	Action<int> act2 = (_) => { value++; };
		//
		// 	subject.Subscribe(act0);
		// 	subject.Subscribe(act1);
		// 	disposable = subject.Subscribe(act2);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(1, value);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XVII() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable = null;
		// 	Action<int> act0 = (_) => { value++; };
		// 	Action<int> act1 = (_) => { disposable.Dispose(); };
		// 	Action<int> act2 = (_) => { value++; };
		//
		// 	subject.Subscribe(act0);
		// 	subject.Subscribe(act1);
		// 	disposable = subject.Subscribe(act2);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(1, value);
		// }
		//
		// [Test]
		// public static void Add_Elements_Remove_During_OnNext_XVIII() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		//
		// 	int value = 0;
		// 	IDisposable disposable0 = null;
		// 	IDisposable disposable1 = null;
		// 	IDisposable disposable2 = null;
		// 	Action<int> act0 = (_) => { disposable0.Dispose(); };
		// 	Action<int> act1 = (_) => { disposable1.Dispose(); };
		// 	Action<int> act2 = (_) => { disposable2.Dispose(); };
		// 	Action<int> act3 = (_) => { value++; };
		//
		// 	disposable0 = subject.Subscribe(act0);
		// 	disposable1 = subject.Subscribe(act1);
		// 	disposable2 = subject.Subscribe(act2);
		// 	subject.Subscribe(act3);
		//
		// 	subject.OnNext(0);
		//
		// 	Assert.AreEqual(1, value);
		// }
		//
		//
		// [Test]
		// public static void Subscribe_To_Disposed() 
		// {
		// 	Subject<int> subject = new Subject<int>();
		// 	subject.Dispose();
		// 	int i = 0;
		// 	subject.Subscribe(
		// 		onNext:(a_int) => { },
		// 		onCompleted: () => { i = 1; }
		// 	);
		//
		// 	Assert.AreEqual(1, i);
		// }
	}
}