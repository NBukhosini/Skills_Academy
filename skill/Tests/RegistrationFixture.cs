using System;
using AventStack.ExtentReports;
using FluentAssertions;
using skill.Reporting;


namespace skill.Tests
{
    public class RegistrationFixture : IClassFixture<BaseFixture>
    {
        private readonly BaseFixture _fixture;

        private ExtentTest _test;

        private Random random = new Random();

        private string GenerateRandomUsername(string baseUsername)
        {
            return $"{baseUsername.Split('@')[0]}_{random.Next(1000, 10000)}@plusnarrative.com";
        }


        public RegistrationFixture(BaseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void RegisterCorrectCredentials()
        {
            _test = ExtentTestManager.CreateTest("RegisterWithCorrectCredentials", "This user should be logged in to our system");

            try
            {
                string randomUsername = GenerateRandomUsername("Test14@plusnarrative.com"); // Generate random username here
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                // Attempt to accept cookies, ignore if not available
                try
                {
                    _fixture.PageLoader.LandingPage.AcceptCookies();
                }
                catch (Exception)
                {
                    // Ignore if AcceptCookies() is not available
                }
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.Registration();
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.NPlusTerminal();
                Thread.Sleep(5000);
                _fixture.PageLoader.RegistrationPage.Singup();
                _fixture.PageLoader.RegistrationPage.register(randomUsername, "Testing@123!");
                Thread.Sleep(5000);
               // var CoursesheadingH1 = _fixture.PageLoader.RegistrationPage.GetCoursesheadingText();

               // CoursesheadingH1.Should().Be("Start your digital and financial skills training");

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
        public void Registerincorrectpassword()
        {
            _test = ExtentTestManager.CreateTest("Registermissingpassword()", "Missing password message should presented");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                // Attempt to accept cookies, ignore if not available
                try
                {
                    _fixture.PageLoader.LandingPage.AcceptCookies();
                }
                catch (Exception)
                {
                    // Ignore if AcceptCookies() is not available
                }
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.Registration();
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.NPlusTerminal();
                Thread.Sleep(5000);

                _fixture.PageLoader.RegistrationPage.register("Test1@plusnarrative.com", ".");

                var errorMessage = _fixture.PageLoader.LoginPage.GetLoginErrorMessage();
                errorMessage.Should().Be("Wrong email or password");

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
        public void RegisterincorrectEmail()
        {
            _test = ExtentTestManager.CreateTest("Registermissingpassword()", "Missing password message should presented");

            try
            {
                _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

                // Attempt to accept cookies, ignore if not available
                try
                {
                    _fixture.PageLoader.LandingPage.AcceptCookies();
                }
                catch (Exception)
                {
                    // Ignore if AcceptCookies() is not available
                }
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.Registration();
                Thread.Sleep(5000);
                _fixture.PageLoader.LandingPage.NPlusTerminal();
                Thread.Sleep(5000);

                _fixture.PageLoader.RegistrationPage.register("Test1@", "Testing@123!");

                var errorMessage = _fixture.PageLoader.LoginPage.GetLoginErrorMessage();
                errorMessage.Should().Be("Wrong email or password");

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
