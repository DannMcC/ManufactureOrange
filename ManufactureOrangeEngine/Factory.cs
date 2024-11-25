using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    internal class Factory
    {
        public static readonly List<BuildMaterial> BuildMaterials = new List<BuildMaterial>();
        public static readonly List<Projectile> Projectiles = new List<Projectile>();

        public const int BUILD_MATERIAL_ID_STEEL = 1;
        public const int BUILD_MATERIAL_ID_LEAD = 2;
        public const int BUILD_MATERIAL_ID_SUPERALLOY= 3;

        static Factory()
        {
            PopulateBuildMaterials();
        }
        private static void PopulateBuildMaterials()
        {
            BuildMaterial Steel = new BuildMaterial(BUILD_MATERIAL_ID_STEEL, "Steel", 1643.15, 820.0);
            BuildMaterial Lead = new BuildMaterial(BUILD_MATERIAL_ID_LEAD, "Lead", 621.5, 311.75);
            BuildMaterial SuperAlloy = new BuildMaterial(BUILD_MATERIAL_ID_SUPERALLOY, "Super Allow", 3288.30, 1640.0);
            BuildMaterials.Add(Steel);
            BuildMaterials.Add(Lead);
            BuildMaterials.Add(SuperAlloy);

            Projectiles.Add(new Projectile(1, "Steel one", Steel));
            Projectiles.Add(new Projectile(1, "Lead one", Lead));
            Projectiles.Add(new Projectile(1, "SuperAlloy one", SuperAlloy));
        }

    }
}
