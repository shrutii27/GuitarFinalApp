using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarFinalApp.Model
{
    internal class GuitarSpec
    {
        public Builder builder { get; }
        public string model { get; }
        public Type type { get; }
        public Wood backWood { get; }
        public Wood topWood { get; }
        public int numStrings { get; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public bool matches(GuitarSpec spec)
        {
           //check if matches fail
            if (builder != spec.builder) { return false; }
            if (!StringsMatch(model, spec.model)) { return false; }
            if (type != spec.type) { return false; }
            if (backWood != spec.backWood) { return false; }
            if (topWood != spec.topWood) { return false; }
            return true;
        }

        private bool StringsMatch(string stringA, string stringB)
        {
            return string.Equals(stringA, stringB, StringComparison.OrdinalIgnoreCase);
        }
    }
}


