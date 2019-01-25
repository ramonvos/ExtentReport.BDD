using Selenium.ExtentReport.BDD.Base;
using Selenium.ExtentReport.BDD.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium.ExtentReport.BDD.Steps
{
    [Binding]
    public class CalculatorSteps : Hooks
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Reporter.AddLogSteps("Step Infor");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Reporter.AddLogSteps("Step Infor");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Reporter.AddLogSteps("Step Infor");
        }

    }
}
