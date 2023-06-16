using System.Text;
using BuilderDesignPattern.Models;
using static System.Console;

namespace BuilderDesignPattern
{
    public class HtmlElement : Models.HtmlElement
    {
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
    }

    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName,string childText)
        {
            var e = new HtmlElement(childName,childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }
        public void Clear()
        {
            root =  new HtmlElement {Name =  rootName};
            root.Elements.Clear();
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //var hello = "hello";
            //var sb = new StringBuilder();
            //sb.Append("<p>");
            //sb.Append(hello);
            //sb.Append("</p>");
            //WriteLine(sb);

            //var words = new[] { "What", "a", "beatiful", "World!!" };
            //sb.Clear();
            //sb.Append("<ul>");
            //foreach (var word in words)
            //{
            //    sb.AppendFormat("<li>{0}</li>", word);
            //}
            //sb.Append("</ul>");
            //WriteLine(sb); 
            #endregion

            //var list = new List<HtmlElement>();
            //HtmlElement h0 = new HtmlElement("h0", "thats ");
            //list.Add(h0);
            //HtmlElement h1 = new HtmlElement("h1", "thats ");
            //list.Add(h1);
            //HtmlElement h2 = new HtmlElement("h2", "thats an encapsulated text", list);
            //list.Add(h2);
            //HtmlElement he3 = new HtmlElement("h3", "thats an encapsulated text", list);
            //list.Add(he3);
            //HtmlElement h = new HtmlElement("h", "thats a text", list);

            //WriteLine(h.ToString());

            var b = new HtmlBuilder("ul");
            //b.AddChild("h1","Welcome");



            WriteLine(b);
        }
    }
}