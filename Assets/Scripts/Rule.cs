using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public abstract class Rule
    {
        public abstract List<Action> Provide(Action action);
    }
}

