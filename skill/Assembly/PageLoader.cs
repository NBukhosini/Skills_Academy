using skill.PageObjects;

namespace skill.Assembly;
public class PageLoader
{
    private readonly IWebDriver _driver;

    public PageLoader(IWebDriver driver)
    {
        _driver = driver;
    }

    public LoginPage LoginPage => GetPage<LoginPage>(_driver);
    public RegistrationPage RegistrationPage => GetPage<RegistrationPage>(_driver);
    public LandingPage LandingPage => GetPage<LandingPage>(_driver);
    public About_usPage About_UsPage => GetPage<About_usPage>(_driver);
    public Skills_pathpage Skills_pathpage => GetPage<Skills_pathpage>(_driver);
    public CoursesPage CoursesPage => GetPage<CoursesPage>(_driver);


    //Image reflection will create an instance on runtime.
    private static T GetPage<T>(IWebDriver driver) where T : class
    {
        return (T)Activator.CreateInstance(typeof(T), driver)! 
               ?? throw new InvalidOperationException();
    }
}
