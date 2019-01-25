using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Selenium.ExtentReport.BDD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.ExtentReport.BDD.Logger
{
    public class Reporter
    {

        public static ExtentReports _extent;
        public static ExtentTest _test;
        public static Scenario scenario;

        public static object ProjetctHelpers { get; private set; }

        public static void InitializeReport()
        {

            string path = ProjectHelper.GetTestDirectoryName();
            string fileName = "Report-BDD.html";

            var htmlReporter = new ExtentHtmlReporter(path + fileName);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);

        }

        public static void AddFeature()
        {
            //Get feature context
            string name = ProjectHelper.GetScenarioName();
            string category = ProjectHelper.GetFeatureName();

            //Create Feature

            _test = _extent.CreateTest<Feature>(name).AssignCategory(category).CreateNode<Scenario>(name);
        }


        public static void AddLogSteps(string step)
        {

            var StepType = ProjectHelper.GetStepType();
            string description = ProjectHelper.GetStepsDescription();
            string status = ProjectHelper.GetScenarioStatus().ToString();

            switch (StepType)
            {
                case TechTalk.SpecFlow.Bindings.StepDefinitionType.Given:
                    _test.CreateNode<Given>(description).Info(status + "<pre> Valor informado: [" + step + "]</pre>");
                    break;

                case TechTalk.SpecFlow.Bindings.StepDefinitionType.When:
                    _test.CreateNode<When>(description).Info(status + "<pre> Valor informado: [" + step + "]</pre>");
                    break;

                case TechTalk.SpecFlow.Bindings.StepDefinitionType.Then:
                    _test.CreateNode<Then>(description).Info(status + "<pre> Valor informado: [" + step + "]</pre>");
                    break;

                default:
                    _test.CreateNode<And>(description).Info(status + "<pre> Valor informado: [" + step + "]</pre>");
                    break;

            }

        }
        public static void GenerateReport()
        {
            _extent.Flush();
        }
    }
}
