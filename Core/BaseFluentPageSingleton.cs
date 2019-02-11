
using OpenQA.Selenium;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FluentPageObjectPattern.Core
{
    public abstract class BaseFluentPageSingleton<TS, TM> : ThreadSafeNestedContructorsBaseSingleton<TS>
        where TM : BasePageElementMap, new()
        where TS : BaseFluentPageSingleton<TS, TM>
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        protected void GoToUrl(string url = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(url));
        }

        protected void WrapStepAction(Action f, IWebElement elt=null)
        {
            f();
            Driver.GetScreenshot(elt);
        }
    }

    public abstract class BaseFluentPageSingleton<TS, TM, TV> : BaseFluentPageSingleton<TS, TM>
        where TM : BasePageElementMap, new()
        where TS : BaseFluentPageSingleton<TS, TM, TV>
        where TV : BasePageValidator<TS, TM, TV>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
                
    }
}