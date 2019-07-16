using PassionCore.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PassionTea
{
    [Binding]
    public class PassionTeaHooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            SeleniumExecutors.Initialize();
            FileHelper.DeleteScreenshotFolder();
        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            SeleniumExecutors.Driver().Close();
        }
        /*
        [AfterStep]
        public  void AfterStep()
        {
            if(ScenarioContext.Current.TestError!=null)
            {
                var featureTitle = TestRunnerManager.GetTestRunner();
                FeatureContext.FeatureInfo.Title;
                // FeatureContext.FeatureInfo.Title;
                var scenarioTitle = TestRunnerManager.GetTestRunner().ScenarioContext.ScenarioInfo.Title;
                var fileName= @"{featureTitle}--{scenarioTitle}";
                SeleniumExecutors.ITakesScreenshot(fileName);
                    }
        }
        */
    }
}
