using BuilderDesignPattern.Builders;
using System.Text;
using static System.Console;

namespace BuilderDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var y = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //var z = Directory.GetDirectories(y).ToArray();
            //foreach ( var f in z ) Console.WriteLine(f);
            #region Introduction without using Builder
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
            //NumberOfitems(10);

            var builder = new HtmlBuilder("ul");
            var y = builder.AddChild("li", "some text");
            builder.AddChild("li", "some text");
            builder.AddChild("li", "some text");
            WriteLine(builder.ToString());

        }
        //private static void NumberOfitems(int n)
        //{
        //    #region Create # encapsulated HtmlElements
        //    var b = new HtmlBuilder("ul");
        //    b.AddChild("h1", "Welcome");
        //    var c = new HtmlBuilder( );

        //    var times = n;
        //    HtmlBuilder[] array = new HtmlBuilder[times]; // Create an array to store HtmlBuilder objects

        //    for (int i = 0; i < times; i++)
        //    {
        //        if (i == array.Length - 1)
        //        {
        //            array[i] = new HtmlBuilder("p");
        //            array[i].AddChild(b);
        //        }
        //        else
        //        {
        //            array[i] = new HtmlBuilder("p");
        //        }
        //        if (i > 0)
        //        {
        //            array[i - 1].AddChild(array[i]);
        //        }
        //    }

        //    c.AddChild(array[0]);
        //    Console.WriteLine(c);
        //    #endregion
        //}
    }
}