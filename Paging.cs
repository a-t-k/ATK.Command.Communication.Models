namespace WebCommunicationModels
{
    /// <summary>
    /// Represents the paging information for data retrieval.
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Represents the filter for the paging. Like a search term or condition.
        /// default is empty string.
        /// </summary>
        public string Filter { get; set; } = string.Empty;

        /// <summary>
        /// Skips the specified number of records.
        /// default is 0.
        /// </summary>
        public int Skip { get; set; } = 0;

        /// <summary>
        /// Takes the specified number of records.
        /// default is 10.
        /// </summary>
        public int Take { get; set; } = 10;
    }
}
