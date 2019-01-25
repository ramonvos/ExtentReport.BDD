using Selenium.ExtentReport.BDD.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium.ExtentReport.BDD.Base
{
    public class Hooks
    {
        [Before]
        public void Before()
        {
            Reporter.InitializeReport();
            Reporter.AddFeature();

        }

        [After]
        public void After()
        {
            Reporter.GenerateReport();
        }
    }
}
