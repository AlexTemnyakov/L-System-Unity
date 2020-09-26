using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class AlgaeAxiomObject : AxiomObject
    {
        public override List<Action> Axiom { get; } = new List<Action>() { new AlgaeActionA() };
    }
}
