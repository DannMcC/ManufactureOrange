﻿using System;
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
        public int BuildMaterialId { get; set; }
        public TemperatureProperties BuildMaterialTemperature { get; set; }
        public BuildMaterial(int materialId, string materialName, TemperatureProperties materialTemperature)
        {
            BuildMaterialId = materialId;
            BuildMaterialName = materialName;
            BuildMaterialTemperature = materialTemperature;
        }
    }
}
