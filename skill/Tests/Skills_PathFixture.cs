using AventStack.ExtentReports;
using FluentAssertions;
using skill.Reporting;

namespace skill.Tests;
public class Skills_PathFixture : IClassFixture<BaseFixture>
{
    private readonly BaseFixture _fixture;

    private ExtentTest _test;


    public Skills_PathFixture(BaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void SkillPathPagePostSurvey()
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
            _fixture.PageLoader.Skills_pathpage.SkillpathOption();
            Thread.Sleep(5000);

            var H1 = _fixture.PageLoader.Skills_pathpage.GetH1Text();

            H1.Should().Be("Your future success begins now!");

            var P1 = _fixture.PageLoader.Skills_pathpage.SkillPathParagraph1();

            P1.Should().Be("Congratulations on taking this positive step towards your career development. Investing time in your education and your personal brand is the best investment you can ever make.");

            var P2 = _fixture.PageLoader.Skills_pathpage.SkillPathParagraph2();

            P2.Should().Be("The results from your survey are shown below. The career fields with the highest percentage will appeal to you most. Click on them and let us help you make an informed career choice to kickstart your future.");



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
    public void RetakeSurvey()
    {
        _test = ExtentTestManager.CreateTest("LoginWithCorrectCredentials", "This user should be logged in to our system");

        try
        {
            _fixture.BrowserHelpers.LaunchBrowser(TestData.LoginData.GetLaunchUrl());
            Thread.Sleep(2000);
            _fixture.PageLoader.LandingPage.AcceptCookies();
            Thread.Sleep(2000);
            _fixture.PageLoader.LandingPage.SingIn();
            Thread.Sleep(2000);
            _fixture.PageLoader.LandingPage.NPlusTerminal();
            Thread.Sleep(3000);

            _fixture.PageLoader.LoginPage.LogIn("Test1@plusnarrative.com", "Testing@123!");
            Thread.Sleep(2000);
            _fixture.PageLoader.Skills_pathpage.SkillpathOption();
            Thread.Sleep(2000);

            var RetakeSurveyBtntXT = _fixture.PageLoader.Skills_pathpage.RetakeSurveyBtntXT();

            RetakeSurveyBtntXT.Should().Be("RE-TAKE SURVEY");
            var RetakeSurveyH2 = _fixture.PageLoader.Skills_pathpage.RetakeSurveyH2();

            RetakeSurveyH2.Should().Be("FEEL LIKE YOUR DIGITAL SKILLSET HAS CHANGED?");

            var RetakeSurveytext = _fixture.PageLoader.Skills_pathpage.RetakeSurveytext();

            RetakeSurveytext.Should().Be("No problem! Just re-take the survey to find out your current digital skills path.");



            
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