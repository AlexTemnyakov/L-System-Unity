using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalPlant
{
    public class FractalPlantAxiomObject : AxiomObject
    {
        public override List<Variable> Axiom { get; } = new List<Variable>() { new X() };
    }
}

