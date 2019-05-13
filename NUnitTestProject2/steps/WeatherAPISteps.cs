using System;
using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using System.Threading;

namespace NUnitTestProject2.steps
{
    [Binding]
    public class WeatherAPISteps
    {
        public object RestClient { get; private set; }
        RestClient restcClient;
        IRestResponse restResponse;
        RestRequest restRequest;

        [Given(@"I have endpoint '(.*)'")]
        public void GivenIHaveEndpoint(string url)
        {
             restcClient = new RestClient(url);
            
        }
        
        [When(@"I have add city '(.*)'")]
        public void WhenIHaveAddCity(string city)
        {
             restRequest = new RestRequest(city, Method.GET);
             restResponse = restcClient.Execute(restRequest);

        }
        [When(@"I have add zip code '(.*)'")]
        public void WhenIHaveAddZipCode(String p0)
        {

            Int32 code = Convert.ToInt32(p0);
            restRequest = new RestRequest(p0, Method.GET);
            restResponse = restcClient.Execute(restRequest);
        }
        //Parameter
        [When(@"I  enter Parameter '(.*)'")]
        public void WhenIEnterParameter(string p0)
        {
            restRequest = new RestRequest(p0, Method.GET);
            restResponse = restcClient.Execute(restRequest);
        }



        [Then(@"I get weather information for '(.*)'")]
        public void ThenIGetWeatherInformationFor(string city)
        {
            string response = restResponse.Content;
             Assert.True(response.Contains(city));
            
        }
        [Then(@"I get weather information zip code for '(.*)'")]
        public void ThenIGetWeatherInformationZipCodeFor(string p0)
        {
            string response = restResponse.Content;
           Assert.True(response.Contains(p0));



        }
        [Then(@"I get weather information '(.*)'")]
        public void ThenIGetWeatherInformation(string p0)
        {
            string response = restResponse.Content;
            Assert.True(response.Contains(p0));
        }



    }
}
