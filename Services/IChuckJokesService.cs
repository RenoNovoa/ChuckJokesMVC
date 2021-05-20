using ChuckNorroeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorroeApi.Services
{
    public interface IChuckJokesService 
    {
        Task<JokeViewModel> GetRandomJoke();
        Task<JokeViewModel> GetRandomJokeByCategory(CategoryViewModel category);
    }
}
