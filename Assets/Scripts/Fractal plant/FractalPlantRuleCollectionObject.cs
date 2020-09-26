using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalPlant
{
    public class FractalPlantRuleCollectionObject : RuleCollectionObject
    {
        public override RuleCollection RuleCollection
        {
            get
            {
                return new FractalPlaneRuleCollection();
            }
        }
    }
}
