namespace WebCommunicationModels
{
    /// <summary>
    /// The notification class.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Gets the severity.
        /// e.g., "success", "info", "warning", "error"
        /// </summary>
        public string Severity { get; set; } = string.Empty;

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets the variables.
        /// </summary>
        public object Variables { get; set; }

        /// <summary>
        /// Creates success notification.
        /// </summary>
        public static Notification Success(string message, string title = null, object variables = null)
        {
            var notification = new Notification
            {
                Severity = "success", Message = message, Title = title, Variables = variables
            };

            return notification;
        }

        /// <summary>
        /// Creates info notification.
        /// </summary>
        public static Notification Info(string message, string title = null, object variables = null)
        {
            var notification = new Notification
            {
                Severity = "info", Message = message, Title = title, Variables = variables
            };

            return notification;
        }

        /// <summary>
        /// Creates info notification.
        /// </summary>
        public static Notification Warning(string message, string title = null, object variables = null)
        {
            var notification = new Notification
            {
                Severity = "warning", Message = message, Title = title, Variables = variables
            };

            return notification;
        }

        /// <summary>
        /// Creates info notification.
        /// </summary>
        public static Notification Error(string message, string title = null, object variables = null)
        {
            var notification = new Notification
            {
                Severity = "error", Message = message, Title = title, Variables = variables
            };

            return notification;
        }
    }
}
