using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public abstract class AxiomObject : MonoBehaviour
    {
        public abstract List<Variable> Axiom { get; }
    }
}
