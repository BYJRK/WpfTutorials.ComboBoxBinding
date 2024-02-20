using System.Globalization;
using System.Windows;

namespace WpfIdeas;

public partial class App : Application
{
    public App()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
    }
}
