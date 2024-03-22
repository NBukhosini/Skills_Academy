
    namespace skill.PageObjects;
    public class CoursesPage : BasePage
    {
        private readonly IWebDriver _driver;

        public CoursesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private static By H1Label => By.XPath("//h1[@class='pn_dashboard-start-title']\n");
        private static By SingInButton => By.XPath("//div[@class='flex items-center gap-8']");
        private static By Accept => By.XPath("//p[@class='MuiTypography-root MuiTypography-body1 pn_btn-yellow css-9l3uo3']");
        private static By PlusNarrativeTerminal => By.XPath("//button[@class='CountryButton_button__k61sC']");
        private static By RegisterBtn => By.XPath("//*[@id=\"__next\"]/main/div/header/div/div/div[1]/a/span");
        private static By CoursesMenuBtn => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div[2]/h1");
        private static By FirstDigitalCourse => By.XPath("//div[@class='pn_course-detail']\n");
        private static By EnrollTodayBtn => By.XPath("//div[@class='pn_coursera-modal-footer']//button[@class='pn_btn-blue flex justify-center']\n");


    public string GetH1Text()
        {
            return GetText(H1Label);
        }
    public bool EnrollTodaybuttonvisible()
    {
        return IsTextVisible(EnrollTodayBtn);
    }
    public void EnrollTodaybutton()
    {
        ClickElement(EnrollTodayBtn);
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

        public void CoursesMenu()
        {
            ClickElement(CoursesMenuBtn);
        }
    public void DigitalbasicCourse()
    {
        ClickElement(FirstDigitalCourse);
    }
  

}