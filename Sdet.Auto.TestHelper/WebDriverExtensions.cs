using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Sdet.Auto.TestHelper
{
	public static class WebDriverExtensions
	{
		public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
		{
			if (timeoutInSeconds > 0)
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
				return wait.Until(drv => drv.FindElement(by));
			}
			return driver.FindElement(by);

			}
					

		public static void WaitForAjax(this IWebDriver driver, int timeoutSecs = 10, bool throwException = false)
		{
			for (var i = 0; i < timeoutSecs; i++)
			{
				var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return window.jQuery != undefined && jQuery.active==0");
				if (ajaxIsComplete) return;
				Thread.Sleep(1000);
			}
			if (throwException)
			{
				throw new Exception("WebDriver timed out waiting for AJAX call to complete");
			}
		}
		


	}



	

}
