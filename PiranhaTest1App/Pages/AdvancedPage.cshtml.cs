
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Piranha.AspNetCore.Services;

using PiranhaTest1App.Models;

namespace PiranhaTest1App.Pages
{
   public class AdvancedPageModel : PageModel
   {
      public AdvancedPage Data { get; private set; }

      //private readonly IApi _api;
      private readonly IModelLoader _loader;
      private readonly ILogger<AdvancedPageModel> _logger;

      public AdvancedPageModel(/*IApi api,*/ IModelLoader loader, ILogger<AdvancedPageModel> logger)
      {
         //_api = api;
         _loader = loader;
         _logger = logger;
      }

      public async Task<IActionResult> OnGet(Guid id, int itemId, bool draft = false)
      {
         _logger.LogInformation($"OnGet, itemId: {itemId}");
         try
         {
            Data = await _loader.GetPageAsync<AdvancedPage>(id, HttpContext.User, draft);

            if (Data == null)
            {
               return NotFound();
            }
            return Page();
         }
         catch (UnauthorizedAccessException)
         {
            return Unauthorized();
         }
      }
   }
}
