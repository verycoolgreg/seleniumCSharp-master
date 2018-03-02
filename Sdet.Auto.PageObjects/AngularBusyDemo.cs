using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;


namespace Sdet.Auto.PageObjects
{
	public class AngularBusyDemo : WebDriverBase
	{
		private static string txtHeader = "div.col-md-12 h2";
		private static string templateUrlLoc = "#template";
		private static string demoBtn = ".btn";
		private static string spinner = "//div[contains(@style,'finalfantasy')]";
		private static string delayInput = "delayInput";

	
		

		public static void VerifyOnHomePage(TestAssert testAssert)
		{
			string headerText = Driver.FindElement(By.CssSelector(txtHeader)).Text;
			testAssert.Pass = LoggingLibrary.CompareResult(headerText, "angular-busy");
		}


		public static void SelectCustomTemplate(string DropDownListValue)
		{

			// select the drop down list
			var templateUrl = Driver.FindElement(By.CssSelector(templateUrlLoc));
			//create select element object 
			var selectElement = new SelectElement(templateUrl);
			//select by value
			selectElement.SelectByValue(DropDownListValue);
			// select by text
			//selectElement.SelectByText("Test");

			// Verify selection
			var selectedValue = selectElement.SelectedOption.GetAttribute("value");
			LoggingLibrary.CompareResult(DropDownListValue, selectedValue);
		}



		public static void ClickDemoBtn()
		{
			Driver.FindElement(By.CssSelector(demoBtn)).Click();			

			// Wait for the busy indicator
			Driver.WaitForAjax();

		}

		public static void DelayInput(string Seconds)
		{
			//Driver.FindElement(By.Id(delayInput)).Click();
			Driver.FindElement(By.Id(delayInput)).Clear();
			Driver.FindElement(By.Id(delayInput)).SendKeys(Seconds);
		}
		

		public static void VerifySpinnerText(string expectedText)
		{
			var spinnerElement = Driver.FindElement(By.ClassName(spinner), 20);
			Assert.AreEqual(expectedText, spinnerElement.Text);
		}




		
		public static bool WaitTillElementisDisplayed(IWebDriver driver, By by, int timeoutInSeconds)
		{
			bool elementDisplayed = false;

			for (int i = 0; i < timeoutInSeconds; i++)
			{
				try
				{
					if (timeoutInSeconds > 0)
					{
						var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
						wait.Until(drv => drv.FindElement(by));
					}
					elementDisplayed = driver.FindElement(by).Displayed;
				}
				catch
				{ }
			}
			return elementDisplayed;

		}





	}

}
