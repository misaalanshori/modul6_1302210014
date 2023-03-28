using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210014
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        static private Random rnd = new Random();
        public SayaTubeUser(string username)
        {
            this.Username = username;
            id = rnd.Next(10000, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                totalPlayCount += uploadedVideos[i].getPlayCount();
            }
            return totalPlayCount;
        }

        public void addVideo(SayaTubeVideo newVideo)
        {
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
