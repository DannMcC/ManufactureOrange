using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    public class BuildMaterial
    {
        public string BuildMaterialName { get; set; }
        public Temperature BuildMaterialTemperature { get; set; }
        public BuildMaterial(string materialName, Temperature materialTemperature)
        {
            BuildMaterialName = materialName;
            BuildMaterialTemperature = materialTemperature;
        }
    }
}
