using Caching.Abstractions.Models;

namespace Caching.Abstractions.Services;

/// <summary>
/// Defines cache service contract
/// </summary>
public interface ICacheService
{
    /// <summary>
    /// Gets a value for a given key from cache
    /// </summary>
    /// <param name="cacheKey">Cache key for value</param>
    /// <typeparam name="TKey">Cache key type</typeparam>
    /// <typeparam name="TValue">Cache value type</typeparam>
    /// <returns>Value if found, otherwise null</returns>
    TValue? GetCacheValue<TKey, TValue>(TKey cacheKey) where TKey : ICacheEntryKey;

    /// <summary>
    /// Sets a value for a given key in cache
    /// </summary>
    /// <param name="cacheKey">Cache key for value</param>
    /// <param name="value">Cache value to set</param>
    /// <typeparam name="TKey">Cache key type</typeparam>
    /// <typeparam name="TValue">Cache value type</typeparam>
    void SetCacheValue<TKey, TValue>(TKey cacheKey, TValue value) where TKey : ICacheEntryKey;
}