namespace DataArt.Tasks
{
    internal class FifthHomework
    {
        public void JokeOrVerse()
        {
            //var synthesizer = new SpeechSynthesizer();
            //synthesizer.SetOutputToDefaultAudioDevice();

            Console.WriteLine("Choose what you want to see: joke or verse");
            var choice = Console.ReadLine();
            var result = "";
            if (choice == "joke")
            {
                var jokeService = new Services.ICanHazDadJokeService();
                result = jokeService.GetJokeAsync().Result;
            }
            else if (choice == "verse")
            {
                var poemService = new Services.PoetryDBService();
                result = poemService.GetPoemAsync().Result;
            }
            else
            {
                Console.WriteLine("Wrong choice");
                return;
            }
            Console.WriteLine(result);

        }
        public void DetermineWhenUserWereBorn()
        {
            Console.WriteLine("Enter sezon of the year you were born(winter, autumn, spring, summer)");
            var season = Console.ReadLine();

            if (season == "winter")
            {
                Console.WriteLine("You were born in January, February or December");
            }
            else if (season == "autumn")
            {
                Console.WriteLine("You were born in September, October or November");
            }
            else if (season == "spring")
            {
                Console.WriteLine("You were born in March, April or May");
            }
            else if (season == "summer")
            {
                Console.WriteLine("You were born in June, July or August");
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
        public void GiveUserRightMenuDependsOnAge()
        {
            Console.WriteLine("Enter your age");
            var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var choice = "";
            if (age == 14)
            {
                Console.WriteLine("Choose menu you want(childr on adult)");
                choice = Console.ReadLine();
                
            }

            if (age < 14 || choice == "child")
            {
                Console.WriteLine("Menu for children");
            }
            else if (choice == "adult")
            {
                Console.WriteLine("Menu for adults");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void EnterLoginAndPassword()
        {
            Console.WriteLine("Enter login");
            var login = Console.ReadLine();
            Console.WriteLine("Enter password");
            var password = Console.ReadLine();

            if (login == "admin" && password == "qwe")
            {
                Console.WriteLine("Welcome, admin");
            }
            else if (login == "user" && password == "user")
            {
                Console.WriteLine("Welcome, user");
            }
            else
            {
                Console.WriteLine("Wrong login or password");
            }
        }
    }
}