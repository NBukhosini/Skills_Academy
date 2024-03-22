using System;
using AventStack.ExtentReports;
using FluentAssertions;
using skill.Reporting;
using FluentAssertions;


namespace skill.Tests
{
    public class About_usFixture : IClassFixture<BaseFixture>
    {
        private readonly BaseFixture _fixture;

        private ExtentTest _test;

        public About_usFixture(BaseFixture fixture)
        {
            _fixture = fixture;
        }


        [Fact]
        public void CheckAboutUsPage()
        {
            _test = ExtentTestManager.CreateTest("Heading Text correct", "Assertion passed");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());
            
                _fixture.PageLoader.LandingPage.AcceptCookies();
                Thread.Sleep(5000);
                _fixture.PageLoader.About_UsPage.OpenAboutpage();


                var heading = _fixture.PageLoader.About_UsPage.GetH1Text();

                heading.Should().Be("About the initiative");



                ExtentTestManager.PassTest();

            }
            catch (Exception exception)
            {

                ExtentTestManager.FailTest(exception.Message);
                ExtentTestManager.AttachScreenShort(_fixture.BrowserHelpers.TakeScreenshotAsBase64());
                throw;

            }
        }

        [Fact]
        public void CheckaboutTheInitiativeContent()
        {
            _test = ExtentTestManager.CreateTest("Heading Text correct", "Assertion passed");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                _fixture.PageLoader.LandingPage.AcceptCookies();
                Thread.Sleep(5000);
                _fixture.PageLoader.About_UsPage.OpenAboutpage();


                var paragraph1 = _fixture.PageLoader.About_UsPage.GetParagraphText1();

                paragraph1.Should().Be("MTN can only flourish when the communities and ecosystems in which it operates are thriving & growing. In all we do, we strive to leverage our core capabilities to enable the socio-economic development of the communities within which we operate.");

                var paragraph2 = _fixture.PageLoader.About_UsPage.GetParagraphText2();

                paragraph2.Should().Be("In alignment with the African Union’s Digital Transformation Strategy for Africa and MTN’s Ambition 2025 strategy, we have launched MTN’s Skills Academy as part of the shift in our Corporate Social Investment towards Digital Skills for Digital Jobs with a view to reach 1 million people by 2025.");

                var paragraph3 = _fixture.PageLoader.About_UsPage.GetParagraphText3();

                paragraph3.Should().Be("The MTN Skills Academy aims to provide access to digital and financial skills training across Africa. By bridging the gap between high demand and low supply, we aim to increase digital skills among young Africans, and increase employment opportunities.");

                ExtentTestManager.PassTest();


            }
            catch (Exception exception)
            {

                ExtentTestManager.FailTest(exception.Message);
                ExtentTestManager.AttachScreenShort(_fixture.BrowserHelpers.TakeScreenshotAsBase64());
                throw;

            }
        }



        [Fact]
        public void CheckIntendedImpactContent()
        {
            _test = ExtentTestManager.CreateTest("Heading Text correct", "Assertion passed");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                _fixture.PageLoader.LandingPage.AcceptCookies();
                Thread.Sleep(5000);
                _fixture.PageLoader.About_UsPage.OpenAboutpage();


                var IntendedImpactH2 = _fixture.PageLoader.About_UsPage.GetIntendedImpactH2();

                IntendedImpactH2.Should().Be("Intended Impact");
                //Thread.Sleep(5000);
                //var IntendedImpact500000 = _fixture.PageLoader.About_UsPage.GetIntendedImpact500000();

                //IntendedImpact500000.Should().Be("DGDG");
                //var IntendedImpact750000 = _fixture.PageLoader.About_UsPage.GetIntendedImpact750000();

                //IntendedImpact750000.Should().Be("The MTN Skills Academy aims to provide access to digital and financial skills training across Africa. By bridging the gap between high demand and low supply, we aim to increase digital skills among young Africans, and increase employment opportunities.");

                //var IntendedImpact150000 = _fixture.PageLoader.About_UsPage.GetIntendedImpact150000();

                //IntendedImpact150000.Should().Be("The MTN Skills Academy aims to provide access to digital and financial skills training across Africa. By bridging the gap between high demand and low supply, we aim to increase digital skills among young Africans, and increase employment opportunities.");

               


                ExtentTestManager.PassTest();


            }
            catch (Exception exception)
            {

                ExtentTestManager.FailTest(exception.Message);
                ExtentTestManager.AttachScreenShort(_fixture.BrowserHelpers.TakeScreenshotAsBase64());
                throw;

            }
        }

        [Fact]
        public void CheckGetDigitalSkillContent()
        {
            _test = ExtentTestManager.CreateTest("Heading Text correct", "Assertion passed");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                _fixture.PageLoader.LandingPage.AcceptCookies();
                Thread.Sleep(5000);
                _fixture.PageLoader.About_UsPage.OpenAboutpage();
                Thread.Sleep(5000);
                // Scroll down the window using JavaScript


                var DigitalSkillH1 = _fixture.PageLoader.About_UsPage.GetDigitalSkillH1();
                DigitalSkillH1.Should().Be("Digital skills programmes linked to digital jobs");


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


