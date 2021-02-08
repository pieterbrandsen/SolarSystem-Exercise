using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolarSystem.Core.Models
{
    public abstract class Object {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Diameter { get; set; }
        public double SurfaceTempMax { get; set; }
        public double SurfaceTempMin { get; set; }
    }

    public sealed class Planet : Object
    {
        public enum TypeOfPlanet
        {
            Planet,
            DwarfPlanet
        }
        public TypeOfPlanet Class { get; set; }

        public long OrbitDistance {get;set;}
        public double OrbitPeriod { get; set; }
        public byte KnownMoons { get; set; }
    }
    public sealed class Star : Object
    {
        public byte AmountOfOrbitingPlanets { get; set; }
        public long Age { get; set; }
        public uint CoreTemp { get; set; }
    }
}
