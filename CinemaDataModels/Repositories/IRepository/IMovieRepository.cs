﻿using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface IMovieRepository
    {
        Task<Movie> CreateAsync(AddMovieRequestDto addMovieRequestDto);
        Task<List<Movie>> GetAllAsync();
        Task<Movie?> GetByIdAsync(int id);
        Task<Movie?> UpdateAsync(int id, Movie movie);
        Task<Movie?> DeleteAsync(int id);
    }
}
