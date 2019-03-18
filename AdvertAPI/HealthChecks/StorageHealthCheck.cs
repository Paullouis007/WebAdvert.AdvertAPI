using AdvertAPI.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AdvertAPI.HealthChecks
{
    public class StorageHealthCheck : IHealthCheck
    {
        private readonly IAdvertStorageService _storageService;

        public StorageHealthCheck(IAdvertStorageService storageService)
        {
            _storageService = storageService;
        }
        //public async ValueTask<IHealthCheckResult> CheckAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var isStorageOk = await _storageService.HealthCheckAsync();
        //    return HealthCheckResult.FromStatus(isStorageOk ? CheckStatus.Healthy : CheckStatus.Unhealthy, "");
        //}

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            var isStorageOk = await _storageService.HealthCheckAsync().ConfigureAwait(false);

            if (isStorageOk)
            {
                return (HealthCheckResult.Healthy("The check indicates a healthy result."));
            }

            return (HealthCheckResult.Unhealthy("The check indicates an unhealthy result."));
        }
    }
}
