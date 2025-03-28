# FileSizeHelper

A utility class written in C# to convert and format file sizes into human-readable units (Bytes, KB, MB, GB). This class helps in displaying file sizes in a more understandable way, especially when dealing with large files.

## Features
- Converts file sizes into Bytes, KB, MB, and GB.
- Includes error handling for invalid paths and file sizes.
- Easy to use and integrate into any C# project.

## How to Use

1. Clone the repository or download the source code.
2. Add the `FileSizeHelper.cs` class to your project.
3. Use the `FileSizeHelper.GetFileSizeFormatted(string filePath)` method to get the formatted file size.

### Example:
```csharp
string filePath = "C:\\path\\to\\your\\file.txt";
string fileSize = FileSizeHelper.GetFileSizeFormatted(filePath);
Console.WriteLine(fileSize); // Outputs: 1.45 MB
