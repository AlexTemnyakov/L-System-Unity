using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algae
{
    public class AlgaeRuleCollection : RuleCollection
    {
        public override List<Variable> Provide(Variable variable)
        {
            List<Variable> expandedVariables = new List<Variable>();

            if (variable is VariableA)
            {
                expandedVariables.Add(new VariableA());
                expandedVariables.Add(new VariableB());
            }
            else if (variable is VariableB)
            {
                expandedVariables.Add(new VariableA());
            }
            else
            {
                expandedVariables.Add(variable);
            }

            return expandedVariables;
        }
    }
}
