using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonCurve
{
    public class DragonCurveRuleCollectionObject : RuleCollectionObject
    {
        public override RuleCollection RuleCollection
        {
            get
            {
                return new DragonCurveRuleCollection();
            }
        }
    }
}
