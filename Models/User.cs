using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sehir_Rehberi.API.Dtos;

namespace sehir_Rehberi.API.Models
{
    public class User
    {
        public User()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<City> Cities { get; set; }
    }
}
