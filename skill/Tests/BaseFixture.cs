using skill.Assembly;
using skill.Browsers;
using skill.Reporting;
using skill.Utilities;

namespace skill.Tests;
public class BaseFixture : IDisposable
{
    public readonly BrowserHelpers BrowserHelpers;
    public readonly PageLoader PageLoader;

    public BaseFixture()
    {
        var factory = new BrowserFactory("");
        var driver = factory.GetDriver(Browser.Chrome);
        
        BrowserHelpers = new BrowserHelpers(driver);
        PageLoader = new PageLoader(driver);
    }

    public void Dispose()
    {
        BrowserHelpers.QuitBrowser();
        ExtentService.Instance.Flush();
    }
}