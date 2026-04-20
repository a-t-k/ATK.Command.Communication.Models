# ATK.Command.Communication.Models

A lightweight .NET Standard 2.1 class library providing reusable data models for web API communication. This library offers essential models for building standardized API responses, handling pagination, managing notifications, and transferring file data.

## Features

- **ApiResponse<T>** - Generic API response wrapper with status, data, message, and notifications support
- **Paging** - Configurable pagination request model with filter, skip, and take parameters
- **PaginationResponse<T>** - Generic pagination response model for paginated data
- **Notification** - Notification model with severity levels and factory methods (Success, Info, Warning, Error)
- **FileModel** - File transfer model with support for both binary and Base64-encoded content

## Installation

Install the NuGet package:

```bash
dotnet add package ATK.Command.Communication.Models
```

Or using the NuGet Package Manager:

```
Install-Package ATK.Command.Communication.Models
```

## Quick Start

### ApiResponse

The `ApiResponse<T>` class provides a standardized API response format with status tracking and notification support:

```csharp
using ATK.Command.Communication.Models;

// Create a successful response
var response = new ApiResponse<User>
{
    Status = "success",
    Data = user,
    Message = "User retrieved successfully"
};

// Check response status
if (response.IsSuccess)
{
    // Handle success
}

// Add notifications
response.Notifications.Add(Notification.Info("Data loaded from cache"));
```

### Pagination

Use the `Paging` model for pagination requests and `PaginationResponse<T>` for responses:

```csharp
// Create a paging request
var paging = new Paging
{
    Filter = "active",
    Skip = 0,
    Take = 20
};

// Create a paginated response
var response = new PaginationResponse<User>
{
    Total = 150,
    Items = users
};
```

### Notifications

The `Notification` class provides factory methods for creating different severity levels:

```csharp
// Create notifications using factory methods
var success = Notification.Success("Operation completed", "Success", new { userId = 123 });
var info = Notification.Info("This is informational", "Info");
var warning = Notification.Warning("Please review this", "Warning");
var error = Notification.Error("An error occurred", "Error");

// Add to response
response.Notifications.AddRange(new[] { success, info });
```

### File Transfer

The `FileModel` class supports both binary and Base64-encoded file content:

```csharp
var fileModel = new FileModel
{
    Name = "document.pdf",
    ContentType = "application/pdf",
    Content = fileBytes
};

// Convert to Base64 for transmission
fileModel.ToBase64();

// Convert back from Base64
fileModel.FromBase64();
```

## Models Overview

### ApiResponse<T>

Generic API response wrapper for standardized communication.

**Properties:**
- `Status` - Response status (success, fail, error, forbidden)
- `Data` - The response payload of type T
- `Message` - Additional response message
- `Notifications` - List of notification objects

**Methods:**
- `IsSuccess` - Check if status is "success"
- `IsFail` - Check if status is "fail"
- `IsForbidden` - Check if status is "forbidden"

### Paging

Request model for paginating data retrieval.

**Properties:**
- `Filter` - Search/filter term (default: empty string)
- `Skip` - Number of records to skip (default: 0)
- `Take` - Number of records to retrieve (default: 10)

### PaginationResponse<T>

Generic response model for paginated data.

**Properties:**
- `Total` - Total number of items available
- `Items` - Collection of paginated items

### Notification

Notification object with severity levels.

**Properties:**
- `Severity` - Severity level (success, info, warning, error)
- `Message` - Notification message
- `Title` - Notification title
- `Variables` - Additional data/context

**Factory Methods:**
- `Success(message, title, variables)`
- `Info(message, title, variables)`
- `Warning(message, title, variables)`
- `Error(message, title, variables)`

### FileModel

File transfer model supporting binary and Base64 encoding.

**Properties:**
- `Content` - Binary file content (byte array)
- `Base64EncodedContent` - Base64-encoded file content
- `Name` - File name
- `ContentType` - MIME type

**Methods:**
- `ToBase64()` - Convert binary content to Base64
- `FromBase64()` - Convert Base64 content to binary

## Requirements

- .NET Standard 2.1 or higher
- .NET Framework 4.7.2+
- .NET Core 3.0+
- .NET 5.0+

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Repository

GitHub: [a-t-k/WebCommunicationModels](https://github.com/a-t-k/WebCommunicationModels)

## Version History

**0.0.3** - Current stable release
