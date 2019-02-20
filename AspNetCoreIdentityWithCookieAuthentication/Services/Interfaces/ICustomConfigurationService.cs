using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentityWithCookieAuthentication.Services.Interfaces
{
    /// <summary>
    /// The Purpose of this service is to give access to all the custom created app settings to access via this service.
    /// </summary>
    public interface ICustomConfigurationService
    {
        string ConnectionString { get; }
    }
}
