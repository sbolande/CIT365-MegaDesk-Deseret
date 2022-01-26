using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Deseret
{
    public static class JsonData
    {
        // file path of JSON DeskQuote List
        private const string _filepath = @"./DeskQuoteData.json";

        /// <summary>
        /// Read JSON from <c>JsonData._filepath</c> as a List of DeskQuotes.
        /// </summary>
        /// <returns>A list of the DeskQuotes.</returns>
        public static List<DeskQuote> Read()
        {
            try
            {
                // read json file, if it doesn't exist then throw
                var jsonString = File.ReadAllText(_filepath);
                return JsonConvert.DeserializeObject<List<DeskQuote>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                // if no file is found then create a default one from an empty list
                Console.Error.WriteLine("File not found! Creating an empty JSON file.");
                var emptyData = new List<DeskQuote>();
                File.WriteAllText(_filepath, JsonConvert.SerializeObject(emptyData));
                return emptyData;
            }
            catch (Exception ex)
            {
                // if there's a problem return an empty list
                Console.Error.WriteLine(ex.Message);
                return new List<DeskQuote>();
            }
        }

        /// <summary>
        /// Appends the given DeskQuote to the JSON file <c>JsonData._filepath</c>.
        /// </summary>
        /// <param name="quote">The DeskQuote to append.</param>
        public static void Write(DeskQuote quote)
        {
            // get all the data
            var data = Read();
            // add our new quote
            data.Add(quote);
            // overwrite file with old + new, equivalent to appending new
            File.WriteAllText(_filepath, JsonConvert.SerializeObject(data));
        }
    }
}
