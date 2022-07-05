using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppMaPay.Pages.Admins
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }

        /*public async Task<IActionResult> OnGet()
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7182/api/admin");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                //string admin = await response.Content.ReadAsStringAsync();
                //admins = await response.Content.ReadFromJsonAsync<List<Admin>>();
                admins = JsonConvert.DeserializeObject<List<Admin>>(result);
            }
            return Page();
        }*/
    }
}
