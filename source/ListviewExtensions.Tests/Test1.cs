using System;
using NUnit.Framework;

namespace ListviewExtensions.Tests
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			TestForm dialog = new TestForm();
			dialog.ShowDialog();
			Assert.IsTrue(true);
		}
	}
}
