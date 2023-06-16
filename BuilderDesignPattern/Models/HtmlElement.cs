using System.Text;

namespace BuilderDesignPattern.Models
{
    public class HtmlElement
    {
        private const int indentSize = 2;
        public List<HtmlElement> Elements = new List<HtmlElement>(); //List of child elements
        public string Name;
        public string Text;

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * ( indent + 1 )));
                sb.AppendLine(Text);
            }
            foreach (var element in Elements)
            {
                sb.Append(element.ToStringImpl(indent + 3));  //recursive
            }
            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

    }
}