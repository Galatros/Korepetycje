﻿using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface IUserRepository
    {
        Task<User> GetUserForNameAsync(string name);

        Task<Book> GetBookForNameAsync(string name);
        Task<Movie> GetMovieForNameAsync(string name);
    }
}