using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public abstract class RuleCollection
    {
        public abstract List<Variable> Provide(Variable variable);
    }
}

