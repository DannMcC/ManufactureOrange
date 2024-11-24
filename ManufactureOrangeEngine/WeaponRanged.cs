using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    public class WeaponRanged : Weapon
    {
        public BuildMaterial WeaponRangedBuildMaterial { get; set; }
        public Projectile WeaponProjectile { get; set; }

        public WeaponRanged(string weaponName, int weaponUseRangeMin, int weaponUseRangeMax, BuildMaterial weaponRangedBuildMaterial, Projectile weaponProjectile) : base(weaponName, weaponUseRangeMin, weaponUseRangeMax)
        {
            WeaponRangedBuildMaterial = weaponRangedBuildMaterial;
            WeaponProjectile = weaponProjectile;
        }
    }
}
