using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PiranhaTest1App.Models
{
   [PageType(Title = "Advanced Page")]
   [ContentTypeRoute(Title = "Default", Route = "/advancedpage")]
   public class AdvancedPage : Page<AdvancedPage>
   {
   }
}
