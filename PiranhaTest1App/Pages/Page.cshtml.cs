
//using Piranha;

//using PiranhaTest1App.PiranhaTypes;

//namespace PiranhaTest1App.Pages
//{
//   public class PageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
//   {
//      private IApi _api;

//      private SimplePage _piranhaPage;

//      public PageModel(IApi api)
//      {
//         _api = api;
//      }

//      public async Task OnGet(Guid id)
//      {
//         _piranhaPage = await _api.Pages.GetByIdAsync<SimplePage>(id);
//      }
//   }
//}
