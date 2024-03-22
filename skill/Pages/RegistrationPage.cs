using System.Reflection.Emit;

namespace skill.PageObjects;
public class RegistrationPage : BasePage
{
    private readonly IWebDriver _driver;
    public RegistrationPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    private static By UsernameInput => By.Id("email");
    private static By PasswordInput => By.Id("password");
    private static By LoginButton => By.XPath("//div[@class='c45d6a94b']");
    private static By SingInButton => By.XPath("/html/body/div/main/section/div/div/div/div[1]/p/a");
    private static By ErrorMessage => By.Id("error-element-password");
    private static By Coursesheading => By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div[2]/h1");

    public void register(string? usernameText, string? passwordText)
    {
        InputText(UsernameInput, usernameText);
        InputText(PasswordInput, passwordText);
        ClickElement(LoginButton);
    }

    public bool IsErrorMessageVisible()
    {
        return WaitForElementVisible(ErrorMessage);
    }

    public string GetLoginErrorMessage()
    {
        return GetText(ErrorMessage);
    }


    public string GetCoursesheadingText()
    {
        return GetText(Coursesheading);
    }

    public string GetregisterErrorMessage()
    {
        return GetText(ErrorMessage);
    }
    public void Singup()
    {
        ClickElement(SingInButton);
    }
}