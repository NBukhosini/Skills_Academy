namespace skill.Utilities;
public static  class TestParameter
{
    public static string Username = "Test1@plusnarrative.com";
    public static string Password = "Testing@123!";
    public static string IncorrectUsername => EnvironmentVariablesReader.GetEnvironmentVariable("INCORRECT_USERNAME");
    public static string IncorrectPassword => EnvironmentVariablesReader.GetEnvironmentVariable("INCORRECT_PASSWORD");
    
    public static string LockedUsername => EnvironmentVariablesReader.GetEnvironmentVariable("LOCKED_USERNAME");
    
    public static string ProblemUsername => EnvironmentVariablesReader.GetEnvironmentVariable("PROBLEM_USERNAME");
    
    public static string PerformanceUsername => EnvironmentVariablesReader.GetEnvironmentVariable("PERFORMANCE_USERNAME");
    
    public static string RemoteUrl => EnvironmentVariablesReader.GetEnvironmentVariable("REMOTE_URL");
}