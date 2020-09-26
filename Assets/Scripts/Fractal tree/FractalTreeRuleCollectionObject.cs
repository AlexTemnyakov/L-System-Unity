using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalTree
{
    public class FractalTreeRuleCollectionObject : RuleCollectionObject
    {
        public override RuleCollection RuleCollection
        {
            get
            {
                return new FractalTreeRuleCollection();
            }
        }
    }
}
