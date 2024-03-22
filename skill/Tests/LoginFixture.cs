using AventStack.ExtentReports;
using FluentAssertions;
using skill.Reporting;

namespace skill.Tests;
public class LoginFixture : IClassFixture<BaseFixture>
{
    private readonly BaseFixture _fixture;

    private ExtentTest _test;
 

    public LoginFixture(BaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void LoginWithCorrectCredentials()
    {
        _test = ExtentTestManager.CreateTest("LoginWithCorrectCredentials", "This user should be logged in to our system");

        try
        {
            _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.AcceptCookies();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.SingIn();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.NPlusTerminal();
            Thread.Sleep(10000);

            _fixture.PageLoader.LoginPage.LogIn("Test1@plusnarrative.com", "Testing@123!");

            //var product = _fixture.PageLoader.LandingPage.GetProductText();
        
            //product.Should().Be("Your pathway");
            
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
    public void LoginWithIncorrectUsername()
    {
        _test = ExtentTestManager.CreateTest("LoginWithIncorrectUsername", "This User has supplied incorrect username to log into the system");
        
        try
        {
            _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

            _fixture.PageLoader.LandingPage.AcceptCookies();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.SingIn();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.NPlusTerminal();
            Thread.Sleep(10000);
            _fixture.PageLoader.LoginPage.LogIn("IncorrectUsername", "Testing@123!");

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
    public void LoginWithIncorrectPassword()
    {
        _test = ExtentTestManager.CreateTest("LoginWithIncorrectUsername", "This User has supplied incorrect username to log into the system");

        try
        {
            _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());

            _fixture.PageLoader.LandingPage.AcceptCookies();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.SingIn();
            Thread.Sleep(5000);
            _fixture.PageLoader.LandingPage.NPlusTerminal();
            Thread.Sleep(10000);
            _fixture.PageLoader.LoginPage.LogIn("Test1@plusnarrative.com", "Incorrect Password");

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