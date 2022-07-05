using AppMaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace AppMaPay.Pages.Admins
{
    public class AdminLoginModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public Admin admin { get; set; }

        HttpClient httpClient = new HttpClient();

        AdminDetails adminDetails = new AdminDetails();
        
        public async Task<IActionResult> OnPostAsync(Admin admin)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                httpClient.BaseAddress = new Uri("https://localhost:7182/api/admin");
                var postlogin = httpClient.PostAsJsonAsync<Admin>("admin", admin);
                postlogin.Wait();
                var postresult = postlogin.Result;
                
                var result = postresult.Content.ReadAsStringAsync().Result;
                adminDetails = JsonConvert.DeserializeObject<AdminDetails>(result);

               
                if (adminDetails.result.result)
                {
                    return Redirect("/Admins/dashboard");
                }
                else
                {
                    return BadRequest(adminDetails.result.message);//response.Content);
                }
            }
        }
    }
}
