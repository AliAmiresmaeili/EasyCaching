﻿namespace EasyCaching.Redis
{
    using EasyCaching.Core.Internal;

    /// <summary>
    /// Redis cache options.
    /// </summary>
    public class RedisCacheOptions : BaseRedisOptions
    {        
        /// <summary>
        /// Gets or sets the Redis database index the cache will use.
        /// </summary>
        /// <value>
        /// The database.
        /// </value>
       public int Database { get; set; } = 0;    
    }
}
