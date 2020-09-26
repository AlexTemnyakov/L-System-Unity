using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalTree
{
    public class FractalTreeAxiomObject : AxiomObject
    {
        public override List<Variable> Axiom { get; } = new List<Variable>() { new Zero() };
    }
}
