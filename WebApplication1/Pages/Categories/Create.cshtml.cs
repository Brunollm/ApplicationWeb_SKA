using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using WebApplication1.Data;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public TaskControl taskControl { get; set; }



        public CreateModel(ApplicationDbContext database)
        {
            _db = database;
        }

        public async Task<IActionResult> OnPost()
        {

            if (taskControl.Name == taskControl.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "O nome não pode ser igual a prioridade ");
            }
            if (ModelState.IsValid)
            {
                await _db.TaskTable.AddAsync(taskControl);
                await _db.SaveChangesAsync();
                TempData["success"] = "Nova Tarefa Adicionada!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
