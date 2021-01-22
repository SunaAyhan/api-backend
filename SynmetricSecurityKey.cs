using Microsoft.IdentityModel.Tokens;
using System;

namespace sehir_Rehberi.API
{
    internal class SynmetricSecurityKey
    {
        private byte[] key;

        public SynmetricSecurityKey(byte[] key)
        {
            this.key = key;
        }

        public static implicit operator SecurityKey(SynmetricSecurityKey v)
        {
            throw new NotImplementedException();
        }
    }
}