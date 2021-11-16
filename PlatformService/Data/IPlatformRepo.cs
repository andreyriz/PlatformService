using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        IEnumerable<Platform> GetAllPlatrorm();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
        public bool SaveChanges();
    }
}
