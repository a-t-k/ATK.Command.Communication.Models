using System.Collections.Generic;

namespace WebCommunicationModels
{
    /// <summary>
    /// The API response object.
    /// </summary>
    public class ApiResponse<T>
    {
        private const string ResponseStatusSuccess = "success";
        private const string ResponseStatusFail = "fail";
        private const string ResponseStatusError = "error";
        private const string ResponseStatusForbidden = "forbidden";

        /// <summary>
        /// Gets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets the notifications.
        /// </summary>
        public List<Notification> Notifications { get; set; } = new List<Notification>();

        /// <summary>
        /// Determines whether this instance is success.
        /// </summary>
        public bool IsSuccess => this.Status == ResponseStatusSuccess;

        /// <summary>
        /// Determines whether this instance is fail.
        /// </summary>
        public bool IsFail => this.Status == ResponseStatusFail;

        /// <summary>
        /// Determines whether request was forbidden.
        /// </summary>
        public bool IsForbidden => this.Status == ResponseStatusForbidden;

        /// <summary>
        /// Determines whether this instance is error.
        /// </summary>
        public bool IsError => this.Status == ResponseStatusError;

        /// <summary>
        /// For creating a success response.
        /// </summary>
        public static ApiResponse<T> Success(T data, string message)
        {
            var response = new ApiResponse<T> { Status = ResponseStatusSuccess, Message = message, Data = data };
            return response;
        }

        /// <summary>
        /// For creating a fail response.
        /// </summary>
        public static ApiResponse<T> Fail(T data, string message)
        {
            var response = new ApiResponse<T> { Status = ResponseStatusFail, Message = message, Data = data };
            return response;
        }

        /// <summary>
        /// For creating an error response.
        /// </summary>
        public static ApiResponse<T> Error(T data, string message)
        {
            var response = new ApiResponse<T> { Status = ResponseStatusError, Message = message, Data = data };
            return response;
        }

        /// <summary>
        /// For creating forbidden response.
        /// </summary>
        public static ApiResponse<T> Forbidden(T data, string message)
        {
            var response = new ApiResponse<T> { Status = ResponseStatusForbidden, Message = message, Data = data };
            return response;
        }

        /// <summary>
        /// Adds the notification.
        /// </summary>
        public ApiResponse<T> With(Notification notification)
        {
            this.Notifications.Add(notification);
            return this;
        }
    }
}
