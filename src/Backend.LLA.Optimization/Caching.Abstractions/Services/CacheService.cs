using System.Collections.Generic;
using Caching.Abstractions.Models;

namespace Caching.Abstractions.Services;

public class CacheService : ICacheService
{
    private readonly ICacheProvider _cacheProvider;

    public CacheService(ICacheProvider cacheProvider)
    {
        _cacheProvider = cacheProvider;
    }

    public TValue? GetCacheValue<TKey, TValue>(TKey cacheKey) where TKey : ICacheEntryKey
    {
        var scopeValues = _cacheProvider.GetCacheValue<Dictionary<string, TValue>>(cacheKey.ScopeKey);
        if (scopeValues == null) return default;

        return scopeValues.TryGetValue(cacheKey.CacheKey, out var value) ? value : default;
    }

    public void SetCacheValue<TKey, TValue>(TKey cacheKey, TValue value) where TKey : ICacheEntryKey
    {
        var scopeValues = _cacheProvider.GetCacheValue<Dictionary<string, TValue>>(cacheKey.ScopeKey) ?? new Dictionary<string, TValue>();
        scopeValues[cacheKey.CacheKey] = value;

        _cacheProvider.SetCacheValue(cacheKey.ScopeKey, scopeValues);
    }
}