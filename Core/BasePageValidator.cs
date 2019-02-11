


using OpenQA.Selenium;
using System;

namespace FluentPageObjectPattern.Core
{
    public class BasePageValidator<TS, TM, TV>
        where TS : BaseFluentPageSingleton<TS, TM, TV>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TS, TM, TV>, new()
    {
        protected TS PageInstance;

        public BasePageValidator(TS currentInstance)
        {
            PageInstance = currentInstance;
        }

        public BasePageValidator()
        {
        }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        protected void WrapValidators(Action f, IWebElement elt = null)
        {
            try
            {
                f();
            }
            catch(Exception ex)
            {
                //Take screenshot in case of failure
                Driver.GetScreenshot(elt);
                throw ex;
            }
            Driver.GetScreenshot(elt);

        }

    }
}