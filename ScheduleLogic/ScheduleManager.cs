using System;
using System.Collections.Generic;
using WebApplication10.Data;
using WebApplication10.Models;
using Microsoft.EntityFrameworkCore;

namespace ScheduleLogic
{
    public class ScheduleManager
    {
        private readonly ApplicationDbContext _context;

        public ScheduleManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetScheduledMovies()
        {
            // Отримати список фільмів з бази даних
            List<Movie> scheduledMovies = _context.Movies.Include(m => m.Showtimes).ToList();

            // Повернути список фільмів
            return scheduledMovies;
        }

    }
}