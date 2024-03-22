namespace skill.PageObjects;
public class About_usPage : BasePage
{
    private readonly IWebDriver _driver;

    public About_usPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    

    private static By SingInButton => By.XPath("//div[@class='flex items-center gap-8']");
    private static By Accept => By.XPath("//p[@class='MuiTypography-root MuiTypography-body1 pn_btn-yellow css-9l3uo3']");
    private static By H1Label => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div/div[1]/h1");
    private static By about_us => By.XPath("//*[@id=\"__next\"]/main/div/div[1]/nav/div/div/div[2]/div[2]/nav/ul/li[2]/a");
    private static By AboutTheInitiativeP1 => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div/div[1]/p[1]");
    private static By AboutTheInitiativeP2 => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div/div[1]/p[2]");
    private static By AboutTheInitiativeP3 => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div/div[1]/p[3]");
    private static By IntendedImpactH2 => By.XPath("//*[@id=\"__next\"]/main/div/div[3]/h2");
    //private static By IntendedImpact500000 => By.XPath("//*[@id=\"__next\"]/main/div/div[3]/div/div[1]/svg");
    //  private static By IntendedImpact75000 => By.XPath("//*[@id=\"__next\"]/main/div/div[3]/div/div[2]");
    //private static By IntendedImpact150000 => By.XPath("//*[@id=\"__next\"]/main/div/div[3]/div/div[3]");
    private static By DigitalSkillH1 => By.XPath("//*[@id=\"__next\"]/main/div/div[4]/div/div[2]/h3[1]");






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

    public void OpenAboutpage()
    {
        ClickElement(about_us);
    }

    public string GetParagraphText1()
    {
        return GetText(AboutTheInitiativeP1);
    }
    public string GetParagraphText2()
    {
        return GetText(AboutTheInitiativeP2);
    }
    public string GetParagraphText3()
    {
        return GetText(AboutTheInitiativeP3);
    }



    public string GetIntendedImpactH2()
    {
        return GetText(IntendedImpactH2);
    }
    //public string GetIntendedImpact500000()
    //{
    //    return GetText(IntendedImpact500000);
    //}
    //public string GetIntendedImpact750000()
    //{
    //    return GetText(IntendedImpact75000);
    //}
    //public string GetIntendedImpact150000()
    //{
    //    return GetText(IntendedImpact150000);
    // }

    public string GetDigitalSkillH1()
    {
        return GetText(DigitalSkillH1);
    }

}