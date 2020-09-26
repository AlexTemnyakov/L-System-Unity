using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonCurve
{
    public class DragonCurveAxiomObject : AxiomObject
    {
        public override List<Variable> Axiom { get; } = new List<Variable>() { new F(), new X() };
    }
}
