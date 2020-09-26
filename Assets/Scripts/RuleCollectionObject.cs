using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public abstract class RuleCollectionObject : MonoBehaviour
    {
        public abstract RuleCollection RuleCollection { get; }
    }
}
