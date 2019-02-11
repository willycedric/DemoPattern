
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace FluentPageObjectPattern.Core
{
    public static class Driver
    {
        private static WebDriverWait _browserWait;

        private static IWebDriver _browser;

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return _browser;
            }
            private set
            {
                _browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return _browserWait;
            }
            private set
            {
                _browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Firefox, int defaultTimeOut = 10)
        {
            //string DriverPath =  Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.InternetExplorer:
                    break;
                case BrowserTypes.Chrome:
                    break;
                default:
                    break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }

        //Must be taken from the App.config
        private static string screenshotPath = @"C:\Users\willy.dongmo\source\repos\FluentPageObjectPattern\bin\Debug\img\";
        /// <summary>
        /// object representing the image of the page on the screen.
        /// </summary>
        /// <returns></returns>
        public static void GetScreenshot()
        {
            var path = screenshotPath + Guid.NewGuid() + ".png";
            try
            {
                Screenshot ss = ((ITakesScreenshot)Driver.Browser).GetScreenshot();

                ss.SaveAsFile(path, ScreenshotImageFormat.Png);
            }
            catch (OpenQA.Selenium.WebDriverException)
            {
                Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

                    bmp.Save(path); // saves the image
                }
            }

        }

        /// <summary>
        /// Scroll to the targeted WebElement before taking a screenshot
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="elt"></param>
        public static void GetScreenshot(IWebElement elt)
        {
            if (elt == null)
                GetScreenshot();
            else
            {
                Driver.Browser.Manage().Window.Maximize();
                //Actions actions = new Actions(Driver.Browser);
                //actions.MoveByOffset(elt.Location.X, elt.Location.Y).Perform();
                IJavaScriptExecutor js = Driver.Browser as IJavaScriptExecutor;
                js.ExecuteScript($"window.scrollBy({elt.Location.X},{elt.Location.Y})");
                GetScreenshot();                
            }

        }

    }
}