using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algae
{
    public class AlgaeRuleCollectionObject : RuleCollectionObject
    {
        public override RuleCollection RuleCollection { get; } = new AlgaeRuleCollection();
    }
}
