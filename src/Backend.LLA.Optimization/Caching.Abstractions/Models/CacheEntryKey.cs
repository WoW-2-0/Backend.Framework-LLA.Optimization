namespace Caching.Abstractions.Models;

public record CacheEntryKey(string ScopeKey, string CacheKey) : ICacheEntryKey;