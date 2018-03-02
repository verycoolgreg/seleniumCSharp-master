using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.PageObjects;
using Sdet.Auto.TestHelper;
using System.Threading;

namespace Sdet.Auto.SeleniumTests
{
	[TestClass]
	public class SeleniumTest : TestBaseClass
	{
		[TestMethod]
		public void TC0001_SmokeTest()
		{

			const string expectedSpinnerText1 = "Please Wait...";
			GuiHelper.OpenWebBrowser();
			Navigation.NavToWebPageUnderTest();
			AngularBusyDemo.VerifyOnHomePage(TestAssert);

			// Acceptance criteria:

			// 1.First, click Demo with message "Please Wait...".  
			// Shows the message "Please Wait..." in the busy indicator
			AngularBusyDemo.ClickDemoBtn();
			AngularBusyDemo.SelectCustomTemplate("custom-template.html");

			AngularBusyDemo.ClickDemoBtn();

			AngularBusyDemo.DelayInput("1000");
			AngularBusyDemo.ClickDemoBtn();
			GuiHelper.CloseWebBrowser();
		}



	}
}
