using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
        
        private Lazy<List<GraphicObject>> _children = new Lazy<List<GraphicObject>>(
            () => new List<GraphicObject>()
        );

        public List<GraphicObject> Children => _children.Value;

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color}")
                .Append($"{Name}")
                .Append(Environment.NewLine);

            foreach (var child in Children)
            {
                child.Print(sb, depth + 1);
            }

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);

            return sb.ToString();
        }
    }
}