namespace Caching.Abstractions.Models;

public static class CacheEntryKeyExtensions
{
    public static ICacheEntryKey WithKey(this ServiceCacheScope cacheScope, ICacheKey cacheKey)
    {
        return new CacheEntryKey($"{cacheScope.ScopeKey}:{cacheKey.ScopeType.ToString()}", cacheKey.CacheKey);
    }
}