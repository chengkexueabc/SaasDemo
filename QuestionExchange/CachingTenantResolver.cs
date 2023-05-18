﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using QuestionExchange.Models;
using SaasKit.Multitenancy;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionExchange
{
    public class CachingTenantResolver : MemoryCacheTenantResolver<Tenant>
    {
        private readonly AppDbContext _context;

        public CachingTenantResolver(AppDbContext context, IMemoryCache cache, ILoggerFactory loggerFactory)
            :base(cache, loggerFactory) 
        {
            _context = context;
        }

        protected override async Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
        {
            var subdomain = context.Request.Host.Host.ToLower();

            var tenant = await _context.Tenants
                .FirstOrDefaultAsync(t => t.Domain == subdomain);

            if (tenant == null) return null;

            return new TenantContext<Tenant>(tenant);
        }

       protected override MemoryCacheEntryOptions CreateCacheEntryOptions()
            => new MemoryCacheEntryOptions().SetSize(1024).SetAbsoluteExpiration(TimeSpan.FromHours(2));

        protected override string GetContextIdentifier(HttpContext context)
            => context.Request.Host.Host.ToLower();

        protected override IEnumerable<string> GetTenantIdentifiers(TenantContext<Tenant> context)
            => new string[] { context.Tenant.Domain };
    }
}
