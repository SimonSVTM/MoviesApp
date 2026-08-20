using MoviesApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApp.Core.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetByTitle(string title);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(string title);
    }
}
