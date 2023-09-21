namespace Caching.Abstractions.Services;

/// <summary>
/// Defines cache provider contract
/// </summary>
public interface ICacheProvider
{
    /// <summary>
    /// Gets cache value for a given key
    /// </summary>
    /// <param name="cacheKy">Cache value key </param>
    /// <typeparam name="TValue">Cache value type</typeparam>
    /// <returns>Value if found, otherwise null</returns>
    TValue? GetCacheValue<TValue>(string cacheKy);

    /// <summary>
    /// Sets cache value for a given key
    /// </summary>
    /// <param name="cacheKey">Cache value key</param>
    /// <param name="value">Value to store</param>
    /// <typeparam name="TValue">Cache value type</typeparam>
    void SetCacheValue<TValue>(string cacheKey, TValue value);
}