using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PiranhaTest1App.Pages
{
   public class PrivacyModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
   {
      private readonly ILogger<PrivacyModel> _logger;

      public PrivacyModel(ILogger<PrivacyModel> logger)
      {
         _logger = logger;
      }

      public void OnGet()
      {
      }
   }
}