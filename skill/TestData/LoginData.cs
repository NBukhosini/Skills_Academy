using skill.Utilities;

namespace skill.TestData;
public static class LoginData
{
    private const string WebsiteUrl = "https://uat.skillsacademy.mtn.com/";
    public static string Username = "Test1@plusnarrative.com";
    public static string Password = "Testing@123!";

    public static string IncorrectUsername => TestParameter.IncorrectUsername;
    public static string IncorrectPassword => TestParameter.IncorrectPassword;
    public static string? EmptyUsername => "";
    public static string? EmptyPassword => "";
    public static string LockedUsername = TestParameter.LockedUsername;
    
    public static string ProblemUsername = TestParameter.ProblemUsername;
    
    public static string PerformanceUsername = TestParameter.PerformanceUsername;
    

    public static string GetLaunchUrl()
    {
        return WebsiteUrl;
    }
    
    public static LoginModel GetCredentialsDetails()
    {
        return new LoginModel(Username, Password);
    }
}