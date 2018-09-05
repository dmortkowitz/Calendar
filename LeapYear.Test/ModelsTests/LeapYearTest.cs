using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.TestTools{
	[TestClass]
	public class LeapYearTest
	{
		[TestMethod]
		public void IsLeapYear_MultiplesOfFourHundred_True()
		{
			LeapYear testLeapYear = new LeapYear();
			Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
		}
	}
}