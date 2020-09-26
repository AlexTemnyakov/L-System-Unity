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

            if (variable is A)
            {
                expandedVariables.Add(new A());
                expandedVariables.Add(new B());
            }
            else if (variable is B)
            {
                expandedVariables.Add(new A());
            }
            else
            {
                expandedVariables.Add(variable);
            }

            return expandedVariables;
        }
    }
}
