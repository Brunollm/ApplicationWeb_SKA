using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public TaskControl taskControl { get; set; }

        public DeleteModel(ApplicationDbContext database)
        {
            _db = database;
        }

        public void OnGet(int id)
        {
            taskControl = _db.TaskTable.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {


            var taskFromDb = _db.TaskTable.Find(taskControl.id);
            if (taskFromDb != null)
            {
                _db.TaskTable.Remove(taskFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Tarefa Excluída!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
