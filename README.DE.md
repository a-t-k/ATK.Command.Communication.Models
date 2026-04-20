# WebCommunicationModels

Eine einfache .NET Standard 2.1 Klassenbibliothek mit wiederverwendbaren Datenmodellen für Web-Kommunikation.

## Übersicht

Dieses Projekt bietet standardisierte Modelle für die Kommunikation zwischen Web-APIs und Clients. Die Modelle ermöglichen eine konsistente Struktur für API-Antworten, Pagination, Benachrichtigungen und Dateiverarbeitung.

## Modelle

### ApiResponse<T>
Standardisierte API-Antwortstruktur mit generischem Datentyp.

**Eigenschaften:**
- `Status`: Antwortstatus (`"success"`, `"fail"`, `"error"`, `"forbidden"`)
- `Data`: Generische Daten vom Typ T
- `Message`: Beschreibung der Antwort
- `Notifications`: Liste von Benachrichtigungen

**Hilfsmethoden:**
- `Success(data, message)`: Erstellt erfolgreiche Antwort
- `Fail(data, message)`: Erstellt Fehler-Antwort
- `Error(data, message)`: Erstellt Error-Antwort
- `Forbidden(data, message)`: Erstellt Verboten-Antwort

### Notification
Benachrichtigungsmodell für Client-Nachrichten.

**Eigenschaften:**
- `Severity`: Art der Benachrichtigung (`"success"`, `"info"`, `"warning"`, `"error"`)
- `Message`: Benachrichtigungstext
- `Title`: Titel (optional)
- `Variables`: Zusätzliche Variablen (optional)

**Hilfsmethoden:**
- `Success(message, title, variables)`
- `Info(message, title, variables)`
- `Warning(message, title, variables)`
- `Error(message, title, variables)`

### FileModel
Modell für Datei-Upload und -Download mit Base64-Unterstützung.

**Eigenschaften:**
- `Content`: Binärer Dateiinhalt (`byte[]`)
- `Base64EncodedContent`: Base64-kodierter Dateiinhalt (`string`)
- `Name`: Dateiname
- `ContentType`: MIME-Type (z.B. `"application/pdf"`)

**Methoden:**
- `ToBase64()`: Konvertiert Binär zu Base64 (löscht Original)
- `FromBase64()`: Konvertiert Base64 zu Binär (löscht Base64)

### Paging
Parameter für Datenpagination.

**Eigenschaften:**
- `Filter`: Suchfilter (Standard: `""`)
- `Skip`: Übersprungene Datensätze (Standard: `0`)
- `Take`: Anzahl abzurufender Datensätze (Standard: `10`)

### PaginationResponse<T>
Antwort mit paginierten Daten.

**Eigenschaften:**
- `Total`: Gesamtanzahl der Datensätze
- `Items`: Abgerufene Datensätze

## Anforderungen

- .NET Standard 2.1 oder höher
- C# 8.0 oder höher

## Verwendungsbeispiel

``` csharp
// Beispiel für die Verwendung von ApiResponse
var response = ApiResponse<string>.Success("Daten erfolgreich geladen", "Die Anfrage war erfolgreich");

// Beispiel für die Verwendung von Notification
var notification = Notification.Success("Die Datei wurde hochgeladen", "Hochladen erfolgreich");

// Beispiel für die Verwendung von FileModel
var fileModel = new FileModel
{
    Name = "beispiel.pdf",
    ContentType = "application/pdf"
};
fileModel.FromBase64("JVBERi0xLjQKJaqrrw0K..."); // Base64 string gekürzt
var base64String = fileModel.ToBase64();

```
