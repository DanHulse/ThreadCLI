using System.Collections.Generic;

namespace ThreadCLI.Services.Interfaces
{
    public interface IDataLoader
    {
        /// <summary>
        /// Reads the data file.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        /// <returns>An <see cref="IEnumerable{String}"/>of all blocks in data file</returns>
        IEnumerable<string> ReadDataFile(string dataFile);
    }
}
