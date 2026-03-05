using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogSite.Pages;

public class ExampleModel : PageModel
{
    [BindProperty]
    public string Name { get; set; } = "Alice";
    public void OnGet()
    {
        ViewData["Date"] = DateTime.Today.ToString("dddd, MM yyyy");
    }

    public IActionResult OnPost()
    {
        OnGet();
        return Page();
    }
}