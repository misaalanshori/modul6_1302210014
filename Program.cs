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
        }
    }
}