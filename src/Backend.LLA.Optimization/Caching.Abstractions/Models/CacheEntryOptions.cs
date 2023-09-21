namespace Caching.Abstractions.Models;

/// <summary>
/// Represents cache entry options
/// </summary>
public class CacheEntryOptions
{
    /// <summary>
    /// Cache value absolute expiration in seconds
    /// </summary>
    public int AbsoluteExpirationInSeconds { get; set; }

    /// <summary>
    /// Cache value sliding expiration in seconds
    /// </summary>
    public int SlidingExpirationInSeconds { get; set; }
}