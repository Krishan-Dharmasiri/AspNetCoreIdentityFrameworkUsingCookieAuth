using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Extension method to serve files from the Node_Modules folder
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, IHostingEnvironment env)
        {
            //Get the absolute path to the node_modules folder
            var path = Path.Combine(env.ContentRootPath,"node_modules");
            //PhysicalFileProvider used to access the actual physical files available on the Disk via File System
            var provider = new PhysicalFileProvider(path);
            //Used to set up where to looak at to get the files
            var options = new StaticFileOptions
            {
                RequestPath = "/node_modules",
                FileProvider = provider
            };
            app.UseStaticFiles(options);

            return app;
        }
    }
}
