using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    public class Weapon
    {
        public string WeaponName { get; set; }
        public int WeaponUseRangeMin { get; set; }
        public int WeaponUseRangeMax { get; set; }
        public Weapon(string weaponName, int weaponUseRangeMin, int weaponUseRangeMax) 
        {
            WeaponName = weaponName;
            WeaponUseRangeMin = weaponUseRangeMin;
            WeaponUseRangeMax = weaponUseRangeMax;
        }
    }
}
