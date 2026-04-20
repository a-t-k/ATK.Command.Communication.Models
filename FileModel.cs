using System;

namespace ATK.Command.Communication.Models
{
    /// <summary>
    /// Presents the model for the upload or download files.
    /// </summary>
    public class FileModel
    {
        /// <summary>
        /// Gets or sets the content of the file.
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// Gets or sets the base64 encoded content of the file.
        /// </summary>
        public string Base64EncodedContent { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>
        /// Converts the Content to Base64EncodedContent and clears the Content.
        /// </summary>
        public void ToBase64()
        {
            this.Base64EncodedContent = Convert.ToBase64String(this.Content);
            this.Content = null;
        }

        /// <summary>
        /// Converts the Base64EncodedContent to Content and clears the Base64EncodedContent.
        /// </summary>
        public void FromBase64()
        {
            this.Content = Convert.FromBase64String(this.Base64EncodedContent);
            this.Base64EncodedContent = null;
        }
    }
}
