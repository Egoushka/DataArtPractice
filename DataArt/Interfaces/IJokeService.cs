namespace DataArt.Interfaces
{
    internal interface IJokeService
    {
        public Task<string> GetJokeAsync();
    }
}
