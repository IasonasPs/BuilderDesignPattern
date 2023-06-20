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

        #region Implementing the fluent builder approach by returning the HtmlBuilder instance in the AddChild methods
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }
        public HtmlBuilder AddChild(HtmlBuilder e)
        {
            root.Elements.Add(e.root);
            return this;
        }
        public HtmlBuilder AddChild(HtmlElement e)
        {
            root.Elements.Add(e);
            return this;
        } 
        #endregion

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