using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TeamScoutAPI.Models;

namespace TeamScoutAPI
{
    public class ImportFileManager
    {
        public List<TweetModels> ImportFile()
        {
            List<TweetModels> result = new List<TweetModels>();
            FileStream stream = File.Open(@"tweet.csv", FileMode.Open);
            StreamReader reader = new StreamReader("tweet.csv");
            while (reader.ReadLine() != null)
            {
                string line = reader.ReadLine();
                string[] dati = line.Split(',');
                TweetModels tweet = new TweetModels()
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
            } return result;
        } 
    }
}