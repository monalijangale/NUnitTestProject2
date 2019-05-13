using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnitTestProject2.Pages;

namespace NUnitTestProject2.steps
{
    [Binding]
    public class CalculatorSteps
    {
       private CalPages pageobj;
        public CalculatorSteps(CalPages obj)
        {
            this.pageobj = obj;
        }




        [Given(@"I have enter url for Calculator Page")]
        public void GivenIHaveEnterUrlForCalculatorPage()
        {

            pageobj.gotoUrl();

        }
        
        [Then(@"I enter first number (.*) in Calculator")]
        public void ThenIEnterFirstNumberInCalculator(Decimal p0)
        {
            pageobj.EnterFirstnumber1(p0);
        }


       
        //click on operator btn
        [Then(@"I have enter '(.*)' operator")]
        public void ThenIHaveEnter(string Operation)
        {
           pageobj.opration(Operation);
        }


        [Then(@"I enter second number (.*) in Calculator")]
        public void ThenIEnterSecondNumberInCalculator(Decimal p0)
        {
            pageobj.secondnumber(p0);
        }



        [When(@"I press equals")]
        public void WhenIPressEquals()
        {
            pageobj.Equalsopratation();
            Thread.Sleep(500);


        }


        //result after calculation

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           Int32 value=pageobj.Result();
           Assert.AreEqual(p0, value);

        }

        
        

        
           //     wait.Until(ExpectedConditions.ElementIsVisible(By.Id("input")));
        

        
       
    }
}
