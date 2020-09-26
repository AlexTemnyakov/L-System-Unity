using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public abstract class RuleObject : MonoBehaviour
    {
        public abstract Rule Rule { get; }
    }
}
