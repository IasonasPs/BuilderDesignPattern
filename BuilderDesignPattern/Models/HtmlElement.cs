using System.Text;

namespace BuilderDesignPattern.Models
{
    public class HtmlElement
    {
        private const int indentSize =4;
        public List<HtmlElement> Elements = new List<HtmlElement>(); //List of child elements
        public string Name;
        public string Text;

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: "name");
            Text = text ?? throw new ArgumentNullException(paramName: "text");
        }
        public HtmlElement(string name, string text, List<HtmlElement> e)
        {
            Name = name ?? throw new ArgumentNullException(paramName: "name");
            Text = text ?? throw new ArgumentNullException(paramName: "text");
            Elements = e.ToList();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            if (Name != null)
            {
                var i = new string(' ', indentSize * indent);
                sb.AppendLine($"{i}<{Name}>");
                if (!string.IsNullOrWhiteSpace(Text))
                {
                    sb.Append(new string(' ', indentSize * ( indent + 1 )));
                    sb.AppendLine(Text);
                }
                foreach (var element in Elements)
                {
                    sb.Append(element.ToStringImpl(indent + 1));  //recursive
                }
                sb.AppendLine($"{i}</{Name}>");
                return sb.ToString();
            }
            else
            {
                var i = new string(' ', indentSize * indent);
                if (!string.IsNullOrWhiteSpace(Text))
                {
                    sb.Append(new string(' ', indentSize * ( indent + 1 )));
                    sb.AppendLine(Text);
                }
                foreach (var element in Elements)
                {
                    sb.Append(element.ToStringImpl(indent + 1));  //recursive
                }
                return sb.ToString();
            }


        }
    }
}