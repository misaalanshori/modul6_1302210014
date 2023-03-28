namespace modul6_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vidio;
            SayaTubeUser misaalanshori = new SayaTubeUser("misaalanshori");
            Random rnd = new Random();

            String[] MovieArray = new string[]
            {
                "Spiderman No Way Home",
                "The Godfather II",
                "12 Angry Men",
                "Suzume",
                "your name.",
                "Weathering with you",
                "5 centimeter per second",
                "The Shawshank Redemption",
                "The Godfather",
                "The Dark Knight"
            };

            for (int i = 0; i < MovieArray.Length; i++)
            {
                vidio = new SayaTubeVideo("Review Film " + MovieArray[i] + " oleh Muhammad Isa Al Anshori");
                vidio.IncreasePlayCount(10000 * rnd.Next(1,25));
                Console.Write("Menambahkan Video: ");
                vidio.PrintVideoDetails();
                misaalanshori.addVideo(vidio);
            }
            misaalanshori.PrintAllVideoPlaycount();
            Console.WriteLine("Total Play Count User: " + misaalanshori.GetTotalVideoPlayCount());

            Console.WriteLine("Mulai Testing...");
            SayaTubeVideo vidioTest;
            SayaTubeUser userTest;
            userTest = new SayaTubeUser(null);
            userTest = new SayaTubeUser("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
            userTest = new SayaTubeUser("testing user");
            vidioTest = new SayaTubeVideo(null);
            vidioTest = new SayaTubeVideo("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            vidioTest = new SayaTubeVideo("VidTest");
            vidioTest.IncreasePlayCount(25000001);
            vidioTest.IncreasePlayCount(-1);
            for (int i = 0; i < 87; i++)
            {
                vidioTest = new SayaTubeVideo("Sebuah Video Testing Oleh Muhammad Isa Al Anshori");
                vidioTest.IncreasePlayCount(25000000);
                userTest.addVideo(vidioTest);
            }
            Console.WriteLine(userTest.GetTotalVideoPlayCount());
            userTest.PrintAllVideoPlaycount();
            


        }
    }
}