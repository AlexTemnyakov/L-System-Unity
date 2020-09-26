using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class LSystem
    {
        public static List<Action> Grow(List<Action> axiom, Rule rule, int numberOfIterations)
        {
            List<Action> actions = new List<Action>();

            actions.AddRange(axiom);

            for (int i = 0; i < numberOfIterations; i++)
            {
                List<Action> newActions = new List<Action>();

                foreach (Action action in actions)
                {
                    newActions.AddRange(rule.Provide(action));
                }

                actions = newActions;
            }

            return actions;
        }
    }
}
