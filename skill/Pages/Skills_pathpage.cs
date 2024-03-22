namespace skill.PageObjects;
public class Skills_pathpage : BasePage
{
    private readonly IWebDriver _driver;

    public Skills_pathpage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    
    private static By H1Label => By.XPath("//h2[contains(@class, 'pb-2')]\n");
    private static By SingInButton => By.XPath("//div[@class='flex items-center gap-8']");
    private static By Accept => By.XPath("//p[@class='MuiTypography-root MuiTypography-body1 pn_btn-yellow css-9l3uo3']");
    private static By PlusNarrativeTerminal => By.XPath("//button[@class='CountryButton_button__k61sC']");
    private static By RegisterBtn => By.XPath("//*[@id=\"__next\"]/main/div/header/div/div/div[1]/a/span");
    private static By SkillpathBtn => By.XPath("//li[a/@href=\"/paths\"]\n");
    private static By Paragraph1 => By.XPath("//p[@class=\"pb-2\"]\n");
    private static By Paragraph2 => By.XPath("//div[@class='w-full lg:w-3/5 text-left']/p[2]\n");
    private static By RetakeSurveyBtn => By.XPath("//a[@class='flex w-[23.54rem]' and span[@class='pn_btn-yellow' and text()='Re-take Survey']]\n");
    private static By RetakeSurveyH2TXT => By.XPath("//div[@class='pn_footer-survey-options order-2 md:order-3 ']//h2\n");
    private static By RetakeSurveyTXT => By.XPath("//div[@class='pn_footer-survey-options order-2 md:order-3 ']//p\n");



    public string GetH1Text()
    {
        return  GetText(H1Label);
    }
    public string SkillPathParagraph1()
    {
        return GetText(Paragraph1);

    }
    public string SkillPathParagraph2()
    {
        return GetText(Paragraph2);

    }
    public string RetakeSurveyBtntXT()
    {
        return GetText(RetakeSurveyBtn);

    }
    public string RetakeSurveyH2()
    {
        return GetText(RetakeSurveyH2TXT);

    }
    public string RetakeSurveytext()
    {
        return GetText(RetakeSurveyTXT);

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

    public void SkillpathOption()
    {
        ClickElement(SkillpathBtn);
    }

}