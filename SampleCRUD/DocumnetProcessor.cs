using Microsoft.Identity.Client;
using SampleCRUD.Interfaces;
using SampleCRUD.Models;

namespace SampleCRUD
{
    public class DocumnetProcessor : IDocumentProcessor
    {
        public Stats Analyze(string documnet)
        {
            if (string.IsNullOrWhiteSpace(documnet))
             throw new ArgumentNullException(nameof(documnet)); 

            var stats = new Stats();

            stats.TotalWords=documnet.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
           // Linq 
            //stats.ToalCharacters=documnet.Count(i=>!char.IsWhiteSpace(i));
            //with loop
            foreach ( var item in documnet)
            {
                if (!char.IsWhiteSpace(item) )
                    stats.ToalCharacters++;

            }
            stats.TotalSentences = documnet.Split('.','!','?').Count(i=> !string.IsNullOrWhiteSpace(i));
            return stats;
        }
    }
}
