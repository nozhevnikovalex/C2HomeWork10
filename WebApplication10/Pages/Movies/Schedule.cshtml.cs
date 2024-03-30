using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication10.Models;
using WebApplication10.Data;
using Microsoft.EntityFrameworkCore;
using ScheduleLogic;


namespace WebApplication10.Pages.Movies
{
    public class ScheduleModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Movie> ScheduledMovies { get; set; }

        public ScheduleModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            //�������� ��������� ����� ����� �������� � �������� �������� ���� �����
            ScheduleManager scheduleManager = new ScheduleManager(_context);

            //�������� ������ ������������ ������ � ������������� ������ GetScheduledMovies
            ScheduledMovies = scheduleManager.GetScheduledMovies();
        }

        //public List<Movie> Movies { get; set; }

        //public void OnGet()
        //{
        //    // ����� �� ���� ����� ��� ��������� ������ ������ �� �� ������
        //    Movies = _context.Movies.Include(m => m.Showtimes).ToList();
        //}
    }
}
