﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Interfaces
{
    public interface ICommonFurnitureProperties
    {
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string? Style { get; set; }
    }
}
