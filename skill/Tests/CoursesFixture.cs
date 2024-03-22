using AventStack.ExtentReports;
using FluentAssertions;
using skill.Assembly;
using skill.Reporting;

namespace skill.Tests;
public class CoursesFixture : IClassFixture<BaseFixture>
{
    private readonly BaseFixture _fixture;

    private ExtentTest _test;


    public CoursesFixture(BaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Courseslandingpage()
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
            Thread.Sleep(5000);
            _fixture.PageLoader.CoursesPage.CoursesMenu();
            Thread.Sleep(5000);

            var H1 = _fixture.PageLoader.CoursesPage.GetH1Text();

            H1.Should().Be("Start your digital and financial skills training");

      

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
    public void SelectDigitalBasicCourse()
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
            Thread.Sleep(5000);
            _fixture.PageLoader.CoursesPage.CoursesMenu();
            Thread.Sleep(5000);

            var H1 = _fixture.PageLoader.CoursesPage.GetH1Text();

            H1.Should().Be("Start your digital and financial skills training");

            _fixture.PageLoader.CoursesPage.DigitalbasicCourse();
            Thread.Sleep(5000);
            // Check if "Data Literacy" text is visible
            bool isDataLiteracyVisible = _fixture.PageLoader.CoursesPage.EnrollTodaybuttonvisible();

            // Assert that "Data Literacy" is visible
            isDataLiteracyVisible.Should().BeTrue();

            _fixture.PageLoader.CoursesPage.EnrollTodaybutton();

             Thread.Sleep(15000);

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