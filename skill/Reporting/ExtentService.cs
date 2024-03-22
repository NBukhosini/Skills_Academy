using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using skill.Utilities;

namespace skill.Reporting;
public static class ExtentService
{
    
    // we are using Lazy loading  to delay loading or initialization until we need it.
    private static readonly Lazy<AventStack.ExtentReports.ExtentReports> Lazy = new(() => new AventStack.ExtentReports.ExtentReports());
    public static AventStack.ExtentReports.ExtentReports Instance => Lazy.Value;

    static ExtentService()
    {
        var reporter = new ExtentHtmlReporter(ReportPath.GetReportFilePath())
        {
            Config =
            {
                Theme = Theme.Standard
            }
        };
        Instance.AttachReporter(reporter);
    }
}