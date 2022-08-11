using DataAccess.Context;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext context;

        public MovieRepository(MovieContext _context)
        {
            context = _context;
        }
        public string GetRanks(int movieId)
        {
            return context.Movies.Where(x => x.Id == movieId).FirstOrDefault().Rank.ToString();
        }
    }
}
