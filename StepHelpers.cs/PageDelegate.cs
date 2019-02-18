using System;
using OpenQA.Selenium; 

using OpenQA.Selenium.Support.UI;

namespace DemoPattern.StepHelpers
{
    public static class PageDelegate
    {

        //Using to fill a form field
        public static Action<IWebElement, string> FillFormEntry = (elt, content) =>
         {
             if (elt.TagName.Equals("select")) //select list
             {
                 new SelectElement(elt).SelectByText(content);
             }
            
             else if (content.Equals(string.Empty) )//Radio box
             {
                 try
                 {
                     elt.Click();
                 }catch(Exception ex)
                 {
                     Console.WriteLine( ex.ToString());
                 }
             }
             else if (content != null && !content.Equals(string.Empty)) //form fields
             {
                 elt.Clear();
                 elt.SendKeys(content);
             }
         };


        public static Func<IWebElement, string, bool> CheckFillEntry = (elt, expectedContent) =>
        {
            if (expectedContent != null && !expectedContent.Equals(string.Empty))
            {
                return elt.Text.ToUpper().Equals(expectedContent.ToUpper());
            }
            else if (expectedContent.Equals(string.Empty))
            {
                return elt.Displayed;
            }
            else
            {
                return false;
            }
        };
    }
}
