namespace skill.PageObjects;
public class LoginPage : BasePage
{
    private readonly IWebDriver _driver;
    public LoginPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    private static By UsernameInput => By.Id("username");
    private static By PasswordInput => By.Id("password");
    private static By LoginButton => By.XPath("//div[@class='c45d6a94b']");
    private static By ErrorMessage => By.Id("error-element-password");
    
    public void LogIn(string? usernameText, string? passwordText)
    {
        InputText(UsernameInput,usernameText);
        InputText(PasswordInput,passwordText);
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

}