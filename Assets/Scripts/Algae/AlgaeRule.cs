using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class AlgaeRule : Rule
    {
        public override List<Action> Provide(Action action)
        {
            List<Action> expandedAction = new List<Action>();

            if (action is AlgaeActionA)
            {
                expandedAction.Add(new AlgaeActionA());
                expandedAction.Add(new AlgaeActionB());
            }
            else if (action is AlgaeActionB)
            {
                expandedAction.Add(new AlgaeActionA());
            }
            else
            {
                expandedAction.Add(action);
            }

            return expandedAction;
        }
    }
}
