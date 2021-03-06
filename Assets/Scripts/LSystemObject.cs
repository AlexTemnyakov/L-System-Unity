﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class LSystemObject : MonoBehaviour
    {
        [Min(1)]
        public int numberOfIterations = 10;

        public GameObject axiomObject;

        public GameObject ruleCollectionObject;

        public bool printResultInConsole = true;

        private List<Variable> variables;

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

            if (ruleCollectionObject == null)
            {
                Debug.LogError("The rule collection object is not set.");
                return;
            }

            if (ruleCollectionObject.GetComponent<RuleCollectionObject>() == null)
            {
                Debug.LogError("The rule collection object does not have the RuleCollectionObject component.");
                return;
            }

            List<Variable> axiom = axiomObject.GetComponent<AxiomObject>().Axiom;

            RuleCollection ruleCollection = ruleCollectionObject.GetComponent<RuleCollectionObject>().RuleCollection;

            variables = LSystem.Grow(axiom, ruleCollection, numberOfIterations);

            if (printResultInConsole)
            {
                string result = "";

                foreach (Variable variable in variables)
                {
                    result += variable.ToString();
                }

                Debug.Log("Result:");
                Debug.Log("Number of variables: " + variables.Count);
                Debug.Log(result);
            }
        }

        public void Clear()
        {
            variables = null;
        }

        public List<Variable> Variables
        {
            get
            {
                return variables;
            }
        }
    }
}
