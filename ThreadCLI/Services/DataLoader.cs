using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ThreadCLI.Helpers;
using ThreadCLI.Services.Interfaces;

namespace ThreadCLI.Services
{
    public class DataLoader : IDataLoader
    {
        /// <summary>
        /// Reads the data file.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        /// <returns>An <see cref="IEnumerable{String}"/>of all blocks in data file</returns>
        public IEnumerable<string> ReadDataFile(string dataFile)
        {
            try
            {
                if (string.IsNullOrEmpty(dataFile))
                {
                    throw new ArgumentNullException(dataFile);
                }

                string dataString;

                var fileStream = new FileStream(dataFile, FileMode.Open, FileAccess.Read);

                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    dataString = streamReader.ReadToEnd();
                }

                var dataFileSplit = dataString.SplitString("{{Scene}}");

                return dataFileSplit.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
