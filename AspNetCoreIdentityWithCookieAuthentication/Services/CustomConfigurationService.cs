using AspNetCoreIdentityWithCookieAuthentication.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace AspNetCoreIdentityWithCookieAuthentication.Services
{
    public class CustomConfigurationService : ICustomConfigurationService
    {
        private IConfiguration _config;

        public CustomConfigurationService(IConfiguration config)
        {
            _config = config;
        }

        public string ConnectionString { get => (_config["ConnectionString"]); }
    }
}
