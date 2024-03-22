using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using WebDriverManager.DriverConfigs.Impl;

namespace skill.Browsers;
public class BrowserFactory
{
    private readonly string _remoteUrl;
    
    public BrowserFactory(string remoteUrl)
    {
        _remoteUrl = remoteUrl;
    }

    public IWebDriver GetDriver()
    {
        return GetChrome();
    }

    public IWebDriver GetDriver(Browser browserName)
    {
        return browserName switch
        {
            Browser.Chrome => GetChrome(),
            Browser.Edge => GetEdge(),
            Browser.FireFox => GetFireFox(),
            _ => throw new ArgumentOutOfRangeException(nameof(browserName), browserName, "Invalid browser passed")
        };
    }
    
    private IWebDriver GetChrome()
    {
        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

        return new ChromeDriver();
    }
    
    private IWebDriver GetEdge()
    {
        new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
        
        return new EdgeDriver();
    }
    
    private IWebDriver GetFireFox()
    {
        var fireFoxOptions = new FirefoxOptions();

        var driver = new RemoteWebDriver(new Uri(_remoteUrl), fireFoxOptions);

        return driver;
    }
}