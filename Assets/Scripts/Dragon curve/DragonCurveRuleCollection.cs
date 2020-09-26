using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonCurve
{
    public class DragonCurveRuleCollection : RuleCollection
    {
        public override List<Variable> Provide(Variable variable)
        {
            List<Variable> expandedVariables = new List<Variable>();

            if (variable is X)
            {
                expandedVariables.Add(new X());
                expandedVariables.Add(new Plus());
                expandedVariables.Add(new Y());
                expandedVariables.Add(new F());
                expandedVariables.Add(new Plus());
            }
            else if (variable is Y)
            {
                expandedVariables.Add(new Minus());
                expandedVariables.Add(new F());
                expandedVariables.Add(new X());
                expandedVariables.Add(new Minus());
                expandedVariables.Add(new Y());
            }
            else
            {
                expandedVariables.Add(variable);
            }

            return expandedVariables;
        }
    }
}
