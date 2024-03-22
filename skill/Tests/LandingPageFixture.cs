using System;
using AventStack.ExtentReports;
using FluentAssertions;
using skill.Reporting;
using FluentAssertions;


namespace skill.Tests
{
    public class LandingPageFixture : IClassFixture<BaseFixture>
    {
        private readonly BaseFixture _fixture;
     
        private ExtentTest _test;
        
        public LandingPageFixture(BaseFixture fixture)
        {
            _fixture = fixture;
        }


        [Fact]
        public void CheckLandingPageH1()
        {
            _test = ExtentTestManager.CreateTest("Heading Text correct", "Assertion passed");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                _fixture.PageLoader.LandingPage.AcceptCookies();
                

                var heading = _fixture.PageLoader.LandingPage.GetH1Text();

                heading.Should().Be("Your pathway\nto a digital career");

                ExtentTestManager.PassTest();

            }
            catch (Exception exception)
            {

                ExtentTestManager.FailTest(exception.Message);
                ExtentTestManager.AttachScreenShort(_fixture.BrowserHelpers.TakeScreenshotAsBase64());
                throw;

            }
        }

      
    }
}


    