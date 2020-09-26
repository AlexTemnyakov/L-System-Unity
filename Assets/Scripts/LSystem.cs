using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class LSystem
    {
        public static List<Variable> Grow(List<Variable> axiom, RuleCollection ruleCollection, int numberOfIterations)
        {
            List<Variable> variables = new List<Variable>();

            variables.AddRange(axiom);

            for (int i = 0; i < numberOfIterations; i++)
            {
                List<Variable> newVariables = new List<Variable>();

                foreach (Variable action in variables)
                {
                    newVariables.AddRange(ruleCollection.Provide(action));
                }

                variables = newVariables;
            }

            return variables;
        }
    }
}
