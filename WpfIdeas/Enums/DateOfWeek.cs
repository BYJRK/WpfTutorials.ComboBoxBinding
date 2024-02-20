using System.ComponentModel;
using WpfIdeas.Properties;

namespace WpfIdeas;

internal enum DateOfWeek
{
    [Description("星期日")]
    [Localization(ResourceName = "Sunday", ResourceType = typeof(Lang))]
    Sunday,

    [Description("星期一")]
    [Localization(ResourceName = "Monday", ResourceType = typeof(Lang))]
    Monday,

    [Description("星期二")]
    [Localization(ResourceName = "Tuesday", ResourceType = typeof(Lang))]
    Tuesday,

    [Description("星期三")]
    [Localization(ResourceName = "Wednesday", ResourceType = typeof(Lang))]
    Wednesday,

    [Description("星期四")]
    [Localization(ResourceName = "Thursday", ResourceType = typeof(Lang))]
    Thursday,

    [Description("星期五")]
    [Localization(ResourceName = "Friday", ResourceType = typeof(Lang))]
    Friday,

    [Description("星期六")]
    [Localization(ResourceName = "Saturday", ResourceType = typeof(Lang))]
    Saturday
}
