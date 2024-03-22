namespace skill.Utilities;
public class ReportPath
{
    public static string  GetReportFilePath()
    {
        var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        var actualPath = path?[..path.LastIndexOf("bin")];
        var projectPath = new Uri(actualPath).LocalPath;
        var reportPath = projectPath + "\\Test_Execution_Reports" + "\\Automation_Report_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"); //TODO 

        return reportPath;
    }
    
}

//public static string RanBy => Environment.UserName;
//public static string HostMachine => Environment.MachineName;
//public static string ReportFolder => Path.Combine(Environment.CurrentDirectory, "Reports");