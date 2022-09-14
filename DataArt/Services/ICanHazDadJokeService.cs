using DataArt.Interfaces;
using ICanHazDadJoke.NET;

namespace DataArt.Services
{
    internal class ICanHazDadJokeService : IJokeService
    {
        private string LibraryName { get; set; } = "ICanHazDadJoke.NET Readme";
        private DadJokeClient Client { get; set; }

        public ICanHazDadJokeService()
        {
            Client = new DadJokeClient(LibraryName);
        }
        public async Task<string> GetJokeAsync()
        {
            return await Client.GetRandomJokeStringAsync();
        }
    }
}
