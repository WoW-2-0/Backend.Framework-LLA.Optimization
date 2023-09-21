namespace Caching.Abstractions.Models;

public interface ICacheEntryKey
{
    string ScopeKey { get; }

    string CacheKey { get; }
}