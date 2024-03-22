namespace skill.PageObjects;
public class LandingPage : BasePage
{
    private readonly IWebDriver _driver;

    public LandingPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    
    private static By H1Label => By.XPath("//*[@id=\"__next\"]/main/div/header/div/div/div[1]/h1");
    private static By SingInButton => By.XPath("//div[@class='flex items-center gap-8']");
    private static By Accept => By.XPath("//p[@class='MuiTypography-root MuiTypography-body1 pn_btn-yellow css-9l3uo3']");
    private static By PlusNarrativeTerminal => By.XPath("//button[@class='CountryButton_button__k61sC']");
    private static By RegisterBtn => By.XPath("//*[@id=\"__next\"]/main/div/header/div/div/div[1]/a/span");
   
    public string GetH1Text()
    {
        return  GetText(H1Label);
    }

    public void SingIn()
    {
       ClickElement(SingInButton); 
    }

    public void AcceptCookies()
    {
        ClickElement(Accept);
    }

    public void NPlusTerminal()
    {
        ClickElement(PlusNarrativeTerminal);
    }

    public void Registration()
    {
        ClickElement(RegisterBtn);
    }


}