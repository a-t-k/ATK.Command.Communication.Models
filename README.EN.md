# WebCommunicationModels

A simple .NET Standard 2.1 class library with reusable data models for web communication.

## Overview

This project provides standardized models for communication between web APIs and clients. The models enable a consistent structure for API responses, pagination, notifications, and file processing.

## Models

### ApiResponse<T>
Standardized API response structure with generic data type.

**Properties:**
- `Status`: Response status (`"success"`, `"fail"`, `"error"`, `"forbidden"`)
- `Data`: Generic data of type T
- `Message`: Description of the response
- `Notifications`: List of notifications

**Helper Methods:**
- `Success(data, message)`: Creates successful response
- `Fail(data, message)`: Creates fail response
- `Error(data, message)`: Creates error response
- `Forbidden(data, message)`: Creates forbidden response

### Notification
Notification model for client messages.

**Properties:**
- `Severity`: Type of notification (`"success"`, `"info"`, `"warning"`, `"error"`)
- `Message`: Notification text
- `Title`: Title (optional)
- `Variables`: Additional variables (optional)

**Helper Methods:**
- `Success(message, title, variables)`
- `Info(message, title, variables)`
- `Warning(message, title, variables)`
- `Error(message, title, variables)`

### FileModel
Model for file upload and download with Base64 support.

**Properties:**
- `Content`: Binary file content (`byte[]`)
- `Base64EncodedContent`: Base64-encoded file content (`string`)
- `Name`: File name
- `ContentType`: MIME-Type (e.g., `"application/pdf"`)

**Methods:**
- `ToBase64()`: Converts binary to Base64 (deletes original)
- `FromBase64()`: Converts Base64 to binary (deletes Base64)

### Paging
Parameters for data pagination.

**Properties:**
- `Filter`: Search filter (default: `""`)
- `Skip`: Number of records to skip (default: `0`)
- `Take`: Number of records to retrieve (default: `10`)

### PaginationResponse<T>
Response with paginated data.

**Properties:**
- `Total`: Total number of records
- `Items`: Retrieved records

## Requirements

- .NET Standard 2.1 or higher
- C# 8.0 or higher

## Usage Example

``` csharp
// Example usage of ApiResponse 
var response = ApiResponse<string>.Success("Data loaded successfully", "Request was successful"); if (response.IsSuccess) { Console.WriteLine(response.Message); }

// Example usage of Notification 
var notification = Notification.Success("File has been uploaded", "Upload successful"); response.Notifications.Add(notification);

// Example usage of FileModel 
var fileModel = new FileModel { Name = "example.pdf", ContentType = "application/pdf", Content = fileBytes }; fileModel.ToBase64(); var base64String = fileModel.Base64EncodedContent;

// Example usage of Paging 
var paging = new Paging { Skip = 0, Take = 10, Filter = "search term" };

// Example usage of PaginationResponse 
var paginatedResponse = new PaginationResponse<User> { Total = 100, Items = users };
var apiResponse = ApiResponse<PaginationResponse<User>>.Success( paginatedResponse, "Users retrieved successfully" );

```
