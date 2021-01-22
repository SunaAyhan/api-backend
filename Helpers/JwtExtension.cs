using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Helpers
{
    
    public static class JwtExtension
    {
        public static void AddAplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Acces-Control-llow-Origin", "*");
            response.Headers.Add("Acces-Control-Expose-Header", "Application-Error");
        }
    }
}
