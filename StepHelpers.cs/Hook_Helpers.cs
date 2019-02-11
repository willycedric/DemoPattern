using System;
using TechTalk.SpecFlow;
using NLog;
using FluentPageObjectPattern.Core;

namespace FluentPageObjectPattern.StepHelpers
{
    [Binding]
    class Hook_Helpers
    {
        protected static Logger mClassLogger = LogManager.GetCurrentClassLogger();
        [BeforeScenario(Order = 0)]
        public static void BeforeScenario()
        {
            mClassLogger.Info("---------------------------------------");
            mClassLogger.Info("Before scenario: '" + ScenarioContext.Current.ScenarioInfo.Title + "'");
            mClassLogger.Info("---------------------------------------");
            mClassLogger.Debug("Starting the browser.");
            Driver.StartBrowser();
        }

        [AfterScenario(Order = 0)]
        public static void AfterScenario()
        {
            mClassLogger.Debug("Inside after scenario..");
            Exception lastError = ScenarioContext.Current.TestError;
            if (lastError != null)
            {
                mClassLogger.Error("error : {0}", lastError.Message);
            }             
            mClassLogger.Debug("Stoping the browser.");
            Driver.StopBrowser();         

            mClassLogger.Debug("---------------------------------------");
        }
    }
}
