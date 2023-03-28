using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null && username.Length <= 100, "Username Tidak Valid");
            this.Username = username;
            id = rnd.Next(10000, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            try
            {
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    totalPlayCount = checked(totalPlayCount + uploadedVideos[i].getPlayCount());
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Penjumlahan Play Count Mencapai Limit Integer");
            }
            
            return totalPlayCount;
        }

        public void addVideo(SayaTubeVideo newVideo)
        {
            Debug.Assert(newVideo != null && newVideo.getPlayCount() < 2147483647, "Video Tidak Valid!");
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
                Debug.Assert(i < 8, "Video yang dicetak melebihi 8!");
            }
        }
    }
}
