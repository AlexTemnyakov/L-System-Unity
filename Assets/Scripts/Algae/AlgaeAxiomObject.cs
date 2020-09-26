using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algae
{
    public class AlgaeAxiomObject : AxiomObject
    {
        public override List<Variable> Axiom { get; } = new List<Variable>() { new A() };
    }
}
