using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public TaskControl taskControl { get; set; }

        public EditModel(ApplicationDbContext database)
        {
            _db = database;
        }

        public void OnGet(int id)
        {
            taskControl = _db.TaskTable.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (taskControl.Name == taskControl.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "O nome não pode ser igual a prioridade ");
            }
            if (ModelState.IsValid) { 
                _db.TaskTable.Update(taskControl);
                await _db.SaveChangesAsync();
                TempData["success"] = "Tarefa Editada com Sucesso!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
