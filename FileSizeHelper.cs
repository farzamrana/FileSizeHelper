using System;
using System.IO;

public static class FileSizeHelper
{
    /// <summary>
    /// Gets the formatted file size (Bytes, KB, MB, GB) from a given file path.
    /// </summary>
    /// <param name="filePath">The full path of the file.</param>
    /// <returns>A string representing the formatted file size.</returns>
    public static string GetFileSizeFormatted(string filePath)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            long fileSize = new FileInfo(filePath).Length;
            return FormatSize(fileSize);
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    /// <summary>
    /// Converts a file size in bytes to a human-readable format (Bytes, KB, MB, GB).
    /// </summary>
    /// <param name="bytes">The file size in bytes.</param>
    /// <returns>A string representing the formatted file size.</returns>
    private static string FormatSize(long bytes)
    {
        if (bytes < 0)
            throw new ArgumentOutOfRangeException(nameof(bytes), "File size cannot be negative.");

        if (bytes < 1024)
            return $"{bytes} Bytes";
        if (bytes < 1024 * 1024)
            return $"{(bytes / 1024.0):0.##} KB";
        if (bytes < 1024 * 1024 * 1024)
            return $"{(bytes / (1024.0 * 1024)):0.##} MB";

        return $"{(bytes / (1024.0 * 1024 * 1024)):0.##} GB";
    }
}
