using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTestProject2.Pages
{
    public class CalPages
    {
        private IWebDriver driver;

        public CalPages(IWebDriver _driver)
        {
            this.driver = _driver;

        }

        public void gotoUrl()
        {
            driver.Navigate().GoToUrl("https://web2.0calc.com/");
            
            try
            {
                
                driver.FindElement(By.Id("cookiesaccept")).Click();
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
              Console.WriteLine("Cookie info button not visible skipping");

            }

        }

        public void EnterFirstnumber1(Decimal p0)
        {
            EnterNumber(p0);

        }

        public void opration(string Operation)
        {
            String opn = "Btn" + Operation;


            driver.FindElement(By.Id(opn)).Click();
        }


        public void secondnumber(Decimal p0)
        {
            EnterNumber(p0);
        }

        public void Equalsopratation()
        {
            driver.FindElement(By.Id("BtnCalc")).Click();


        }
        public int Result()
        {
            IWebElement a = driver.FindElement(By.Id("input"));
            int val = Convert.ToInt32(a.GetAttribute("value"));
            Console.Write(val);
            return val;



        }
        public void EnterNumber(Decimal no1)
        {
            string no = no1.ToString(); ;
            string[] numberArray = new string[no.Length];
            int counter = 0;
            int index = 0;


            Console.Write(no);

            if (System.Convert.ToInt32(no1) < 0)
            {
                driver.FindElement(By.Id("BtnMinus")).Click();
                index = 1;
            }

            for (int j = 0; j < no.Length; j++)
            {
                numberArray[j] = no.Substring(counter, 1); // 1 is split length
                counter++;
            }



            for (int i = index; i < numberArray.Length; i++)
            {
                 if (numberArray.Contains("."))
                {
                
                 driver.FindElement(By.Id("BtnDot")).Click();
                  }
                   else
                  {
                driver.FindElement(By.Id("Btn" + numberArray[i])).Click();
                 }
            }


        }







    }
}

