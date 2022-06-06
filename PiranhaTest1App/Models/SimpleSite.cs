using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaTest1App.Models
{
   [SiteType(Title = "Simple Site")]
   public class SimpleSite : SiteContent<SimpleSite>
   {
      [Region]
      public ImageField Logo { get; set; }
   }
}
