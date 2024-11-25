using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    public class Projectile
    {
        public int ProjectileID { get; set; }
        public string ProjectileName { get; set; }
        public BuildMaterial ProjectileMaterial { get; set; }
        public Projectile(int projectileID, string projectileName, BuildMaterial projectileMaterial)
        {
            ProjectileID = projectileID;
            ProjectileName = projectileName;
            ProjectileMaterial = projectileMaterial;
        }
    }
}
