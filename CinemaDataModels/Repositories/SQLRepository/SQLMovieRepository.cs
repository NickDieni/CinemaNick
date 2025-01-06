using CinemaDataModels.Data;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLMovieRepository : IMovieRepository
    {
        private readonly CinemaContext dbContext;

        public SQLMovieRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Movie> CreateAsync(AddMovieRequestDto addMovieRequestDto)
        {
            var movie = new Movie
            {
                Title = addMovieRequestDto.Title,
                DurationMinutes = addMovieRequestDto.DurationMinutes,
                Rating = addMovieRequestDto.Rating,
                ReleaseDate = addMovieRequestDto.ReleaseDate,
                Genres = new List<Genre>()
            };

            foreach (var genreId in addMovieRequestDto.GenreIds)
            {
                var genre = await dbContext.Genres.FindAsync(genreId);
                if (genre != null)
                {
                    movie.Genres.Add(genre);
                }
            }

            await dbContext.Movies.AddAsync(movie);
            await dbContext.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> DeleteAsync(int id)
        {
            var existingMovie = await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);

            if (existingMovie == null)
            {
                return null;
            }

            dbContext.Movies.Remove(existingMovie); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingMovie;
        }

        public async Task<List<Movie>> GetAllAsync()
        {
            return await dbContext.Movies.ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);
        }

        public async Task<Movie?> UpdateAsync(int id, Movie movie)
        {
            var existingMovie = await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);
            if (existingMovie == null)
            {
                return null;
            }

            existingMovie.Title = movie.Title;
            existingMovie.DurationMinutes = movie.DurationMinutes;
            existingMovie.ReleaseDate = movie.ReleaseDate;
            existingMovie.Rating = movie.Rating;
            existingMovie.Genres = movie.Genres;


            await dbContext.SaveChangesAsync();
            return existingMovie;
        }
    }
}