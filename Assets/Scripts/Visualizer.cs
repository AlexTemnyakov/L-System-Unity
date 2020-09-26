using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSystem
{
    public class Visualizer : MonoBehaviour
    {
        public GameObject lsystemObject;

        public float angle = 25f;

        [Min(1f)]
        public float lineLength = 10;

        public Color lineColor = Color.white;

        public Vector3 startPosition = Vector3.zero;

        public Vector3 startDirection = Vector3.forward;

        void Update()
        {

        }

        public void Draw()
        {
            if (lsystemObject != null && lsystemObject.GetComponent<LSystemObject>() != null)
            {
                Vector3 position = startPosition;

                Vector3 direction = startDirection.normalized;

                Stack<StackEntry> stack = new Stack<StackEntry>();

                List<Variable> variables = lsystemObject.GetComponent<LSystemObject>().Variables;

                if (variables != null)
                {
                    foreach (Variable variable in variables)
                    {
                        if (variable is F)
                        {
                            Vector3 newPosition = position + direction * lineLength;

                            Gizmos.color = lineColor;
                            Gizmos.DrawLine(position, newPosition);

                            position = newPosition;
                        }
                        else if (variable is LeftBracket)
                        {
                            stack.Push(new StackEntry(position, direction));
                        }
                        else if (variable is RightBracket)
                        {
                            StackEntry poppedEntry = stack.Pop();

                            position = poppedEntry.position;

                            direction = poppedEntry.direction;
                        }
                        else if (variable is Plus)
                        {
                            direction = Quaternion.Euler(0f, -angle, 0f) * direction;
                        }
                        else if (variable is Minus)
                        {
                            direction = Quaternion.Euler(0f, angle, 0f) * direction;
                        }
                    }
                }
            }
        }

        void OnDrawGizmos()
        {
            Draw();
        }

        private class StackEntry
        {
            public Vector3 position;

            public Vector3 direction;

            public StackEntry(Vector3 __position, Vector3 __direction)
            {
                position = __position;

                direction = __direction;
            }
        }
    }
}
