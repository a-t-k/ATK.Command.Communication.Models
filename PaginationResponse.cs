using System;
using System.Collections.Generic;

namespace WebCommunicationModels
{
    /// <summary>
    /// The pagination response.
    /// </summary>
    public class PaginationResponse<T> where T : class
    {
        /// <summary>
        /// Sets or gets the total number of items.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Sets or gets the items.
        /// </summary>
        public IEnumerable<T> Items { get; set; } = Array.Empty<T>();
    }
}
