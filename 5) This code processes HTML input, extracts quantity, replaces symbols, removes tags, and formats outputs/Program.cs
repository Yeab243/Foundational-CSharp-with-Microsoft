using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

public class Program
{
    public static void Main(string[] args)
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Create an HTML parser
        var document = new HtmlDocument();
        document.LoadHtml(input);

        // Extract the quantity
        var quantityNode = document.DocumentNode.SelectSingleNode("span");
        if (quantityNode != null)
        {
            quantity = quantityNode.InnerText;
        }
        quantity = $"Quantity: {quantity}";

        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        output = input.Replace("&trade;", "&reg;");

        // Remove the opening and closing <div> tags
        output = output.Replace("<div>", "").Replace("</div>", "");
        output = $"Output: {output}";

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }
}

