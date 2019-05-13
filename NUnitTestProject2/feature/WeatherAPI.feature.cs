// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NUnitTestProject2.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("WeatherAPI")]
    public partial class WeatherAPIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WeatherAPI.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WeatherAPI", "\tIn order to get weather information\r\n\tAs a user\r\n\tAs a math idiot\r\n\tI want to be" +
                    " get weather information from API", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify weather API with city name")]
        [NUnit.Framework.CategoryAttribute("api")]
        public virtual void VerifyWeatherAPIWithCityName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify weather API with city name", null, new string[] {
                        "api"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("I have endpoint \'http://restapi.demoqa.com/utilities/weather/city/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("I have add city \'Pune\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I get weather information for \'Pune\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify weather API with zip code")]
        public virtual void VerifyWeatherAPIWithZipCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify weather API with zip code", null, ((string[])(null)));
#line 13
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("I have endpoint \'http://restapi.demoqa.com/utilities/weather/city/zipcode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I have add zip code \'414105\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I get weather information zip code for \'Ahmadnagaar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify weather API with city and Zip code")]
        [NUnit.Framework.TestCaseAttribute("Pune", "Pune", null)]
        [NUnit.Framework.TestCaseAttribute("4123512765", "An internal error occured while servicing the request", null)]
        [NUnit.Framework.TestCaseAttribute("0000", "An internal error occured while servicing the request", null)]
        [NUnit.Framework.TestCaseAttribute("414105", "Ahmadnagar", null)]
        [NUnit.Framework.TestCaseAttribute("", "Invalid or Missing GET data, please correct the request", null)]
        public virtual void VerifyWeatherAPIWithCityAndZipCode(string parameter, string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify weather API with city and Zip code", null, exampleTags);
#line 19
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
 testRunner.Given("I have endpoint \'http://restapi.demoqa.com/utilities/weather/city/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When(string.Format("I  enter Parameter \'{0}\'", parameter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then(string.Format("I get weather information \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion