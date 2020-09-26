using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalPlant
{
    public class FractalPlaneRuleCollection : RuleCollection
    {
        public override List<Variable> Provide(Variable variable)
        {
            List<Variable> expandedVariables = new List<Variable>();

            if (variable is X)
            {
                expandedVariables.Add(new F());
                expandedVariables.Add(new Plus());
                expandedVariables.Add(new LeftBracket());
                expandedVariables.Add(new LeftBracket());
                expandedVariables.Add(new X());
                expandedVariables.Add(new RightBracket());
                expandedVariables.Add(new Minus());
                expandedVariables.Add(new X());
                expandedVariables.Add(new RightBracket());
                expandedVariables.Add(new Minus());
                expandedVariables.Add(new F());
                expandedVariables.Add(new LeftBracket());
                expandedVariables.Add(new Minus());
                expandedVariables.Add(new F());
                expandedVariables.Add(new X());
                expandedVariables.Add(new RightBracket());
                expandedVariables.Add(new Plus());
                expandedVariables.Add(new X());
            }
            else if (variable is F)
            {
                expandedVariables.Add(new F());
                expandedVariables.Add(new F());
            }
            else
            {
                expandedVariables.Add(variable);
            }

            return expandedVariables;
        }
    }
}
