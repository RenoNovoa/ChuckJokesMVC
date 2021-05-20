using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using ChuckNorroeApi.Models;

namespace ChuckNorroeApi.Services
{
    public class ChuckJokesService : IChuckJokesService
    {
        private readonly HttpClient _client;

        public ChuckJokesService(HttpClient client )
        {
            _client = client;
        }


        //here we create the end point 
        public async Task<JokeViewModel> GetRandomJoke()
        {
            var result = await _client.GetFromJsonAsync<JokeViewModel>("random"); //EndPoint
            return result;
        }

        public async Task<JokeViewModel> GetRandomJokeByCategory(CategoryViewModel category)
        {
            var result = await _client.GetFromJsonAsync<JokeViewModel>($"random?category={category.Categories}");
            return result;
        }
    }
}
