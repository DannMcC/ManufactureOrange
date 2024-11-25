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
            TemperatureProperties steelTemperatureProperties = new TemperatureProperties(1643.15, 820.0);
            TemperatureProperties leadTemperatureProperties = new TemperatureProperties(621.5, 311.75);
            TemperatureProperties superAlloyTemperatureProperties = new TemperatureProperties(3288.30, 1643.15);

            BuildMaterial Steel = new BuildMaterial(BUILD_MATERIAL_ID_STEEL, "Steel", steelTemperatureProperties);
            BuildMaterial Lead = new BuildMaterial(BUILD_MATERIAL_ID_LEAD, "Lead", leadTemperatureProperties);
            BuildMaterial SuperAlloy = new BuildMaterial(BUILD_MATERIAL_ID_SUPERALLOY, "Super Allow", superAlloyTemperatureProperties);

            BuildMaterials.Add(Steel);
            BuildMaterials.Add(Lead);
            BuildMaterials.Add(SuperAlloy);

            Projectiles.Add(new Projectile(1, "Steel one", Steel));
            Projectiles.Add(new Projectile(1, "Lead one", Lead));
            Projectiles.Add(new Projectile(1, "SuperAlloy one", SuperAlloy));
        }

    }
}
