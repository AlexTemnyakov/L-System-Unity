using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalTree
{
    public class FractalTreeRuleCollection : RuleCollection
    {
        public override List<Variable> Provide(Variable variable)
        {
            List<Variable> expandedVariables = new List<Variable>();

            if (variable is One)
            {
                expandedVariables.Add(new One());
                expandedVariables.Add(new One());
            }
            else if (variable is Zero)
            {
                expandedVariables.Add(new One());
                expandedVariables.Add(new LeftBracket());
                expandedVariables.Add(new Zero());
                expandedVariables.Add(new RightBracket());
                expandedVariables.Add(new Zero());
            }
            else
            {
                expandedVariables.Add(variable);
            }

            return expandedVariables;
        }
    }
}
