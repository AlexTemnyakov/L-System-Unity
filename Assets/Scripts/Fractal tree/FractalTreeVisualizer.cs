using LSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FractalTree
{
    public class FractalTreeVisualizer : MonoBehaviour
    {
        public GameObject lsystemObject;

        [Min(1f)]
        public float lineLength = 10;

        [Min(1f)]
        public float leafSphereRadius = 2f;

        public Color lineColor = Color.white;

        public Color leafSphereColor = Color.green;

        public Vector3 startPosition = Vector3.zero;

        public Vector3 startDirection = Vector3.forward;

        void OnDrawGizmos()
        {
            if (lsystemObject != null && lsystemObject.GetComponent<LSystemObject>() != null)
            {
                Vector3 position = startPosition;

                Vector3 direction = startDirection.normalized;

                Stack<FractalTreeStackEntry> stack = new Stack<FractalTreeStackEntry>();
 
                List<Variable> variables = lsystemObject.GetComponent<LSystemObject>().Variables;

                if (variables != null)
                {
                    foreach (Variable variable in variables)
                    {
                        if (variable is One)
                        {
                            Vector3 newPosition = position + direction * lineLength;

                            Gizmos.color = lineColor;
                            Gizmos.DrawLine(position, newPosition);

                            position = newPosition;
                        }
                        else if (variable is Zero)
                        {
                            Vector3 newPosition = position + direction * lineLength;

                            Gizmos.color = lineColor;
                            Gizmos.DrawLine(position, newPosition);
                            Gizmos.color = leafSphereColor;
                            Gizmos.DrawSphere(newPosition, leafSphereRadius);

                            position = newPosition;
                        }
                        else if (variable is LeftBracket)
                        {
                            stack.Push(new FractalTreeStackEntry(position, direction));

                            direction = Quaternion.Euler(0f, -45f, 0f) * direction;
                        }
                        else if (variable is RightBracket)
                        {
                            FractalTreeStackEntry poppedEntry = stack.Pop();

                            position = poppedEntry.position;

                            direction = Quaternion.Euler(0f, 45f, 0f) * poppedEntry.direction;
                        }
                    }
                }                
            }
        }

        private class FractalTreeStackEntry
        {
            public Vector3 position;

            public Vector3 direction;

            public FractalTreeStackEntry(Vector3 __position, Vector3 __direction)
            {
                position = __position;

                direction = __direction;
            }
        }
    }
}
