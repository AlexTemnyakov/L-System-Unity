using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class LSystemObject : MonoBehaviour
    {
        [Min(1)]
        public int numberOfIteration = 10;

        public GameObject axiomObject;

        public GameObject ruleObject;

        private List<Action> actions;

        void Start()
        {

        }

        void Update()
        {

        }

        public void Grow()
        {
            if (axiomObject == null)
            {
                Debug.LogError("The axiom object is not set.");
                return;
            }

            if (axiomObject.GetComponent<AxiomObject>() == null)
            {
                Debug.LogError("The axiom object does not have the AxiomObject component.");
                return;
            }

            if (ruleObject == null)
            {
                Debug.LogError("The rule object is not set.");
                return;
            }

            if (ruleObject.GetComponent<RuleObject>() == null)
            {
                Debug.LogError("The rule object does not have the RuleObject component.");
                return;
            }

            List<Action> axiom = axiomObject.GetComponent<AxiomObject>().Axiom;

            Rule rule = ruleObject.GetComponent<RuleObject>().Rule;

            actions = LSystem.Grow(axiom, rule, numberOfIteration);

            string result = "";

            foreach (Action action in actions)
            {
                result += action.ToString();
            }

            Debug.Log("Result:");
            Debug.Log(result);
        }
    }
}
