using UnityEngine;

namespace XNode.Examples.MathNodes
{
    public class HelloNode : Node
    {
        [Input] public string input;
        [Output] public string output;
        public string add;

        public override object GetValue(NodePort port)
        {
            var inp = GetInputValue("input", input);
            return string.IsNullOrEmpty(inp) ? $"Hello {add}" : $"{inp} + {add}";
        }
    }
}