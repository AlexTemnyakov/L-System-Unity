using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class AlgaeRuleObject : RuleObject
    {
        public override Rule Rule { get; } = new AlgaeRule();
    }
}
