using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Builders
{
    public class HtmlBuilder
    {
        private readonly string rootName;

        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public HtmlBuilder()
        {
        }

        public HtmlElement AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return root;
        }
        public   void AddChild(HtmlBuilder e)
        {
            root.Elements.Add(e.root);
        }
        public void AddChild(HtmlElement e)
        {
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }
        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
            root.Elements.Clear();
        }
    }
}