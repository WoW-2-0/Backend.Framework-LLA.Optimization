namespace Caching.Abstractions.Models;

public interface ICacheKey
{
    string ScopeKey { get; set; }
    string CacheKey { get; set; }
}