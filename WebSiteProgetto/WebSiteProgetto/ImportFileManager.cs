using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebSiteProgetto.Models;

namespace WebSiteProgetto
{
    public class ImportFileManager
    {
        public List<TweetModel> ImportFile() 
        {
            List<TweetModel> result = new List<TweetModel>();
            FileStream stream = File.Open(@"tweet.csv", FileMode.Open);
            StreamReader reader = new StreamReader();
            while (reader.ReadLine() != null)
            {
                string line = reader.ReadLine();
                string[] dati = line.Split(',');
                TweetModel tweet = new TweetModel()
                {
                    Id = Convert.ToInt32(dati[0]),
                    data = dati[1],
                    testo = ""
                };
                for (int i = 2; i < dati.Length; i++)
                {
                    tweet.testo += dati[i];
                }
                result.Add(tweet);
            }
        }
    }
}