using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<TaskControl> taskControls { get; set; }

        public IndexModel(ApplicationDbContext database)
        {
            _db = database;
        }

        public void OnGet()
        {
            taskControls = _db.TaskTable;
        }
    }
}
