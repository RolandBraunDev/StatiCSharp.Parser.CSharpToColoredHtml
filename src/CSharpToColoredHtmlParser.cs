using CsharpToColouredHTML.Core;
using StatiCSharp.Interfaces;
using System.Text;

namespace StatiCSharp.Parser.CSharpToColoredHtmlParser;

public class CSharpToColoredHtmlParser : IPipelineParser
{
    private bool _disableLineNumbers = false;
    private string _openingMarker = "```cs";
    private string _closingMarker = "```";
    public string HeaderContent => string.Empty;

    public CSharpToColoredHtmlParser DisableLineNumbers()
    {
        _disableLineNumbers = true;
        return this;
    }

    public string Parse(string input)
    {
        input = ReplaceMarkerVariations(input, _openingMarker);

        var settings = new HTMLEmitterSettings()
            .DisableIframe()
            .UseCustomCSS(CustomCss.WithLineNumbers);

        if (_disableLineNumbers)
        {
            settings.DisableLineNumbers()
                .UseCustomCSS(CustomCss.WithoutLineNumbers);
        }

        var markers = FindMarkers(input, _openingMarker, _closingMarker);
        while (markers != (-1, -1))
        {
            string leadingText = input.Substring(0, markers.Leading);
            
            string codeText = input.Substring(
                markers.Leading + _openingMarker.Length,
                markers.Trailing - markers.Leading - _openingMarker.Length
                ).Trim();
            
            string trailingText = input.Substring(markers.Trailing + _closingMarker.Length);

            codeText = new CsharpColourer().ProcessSourceCode(codeText, new HTMLEmitter(settings));

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(leadingText);
            stringBuilder.Append(codeText);
            stringBuilder.Append(trailingText);
            input = stringBuilder.ToString();
            markers = FindMarkers(input, _openingMarker, _closingMarker);
        }

        return input;
    }

    private (int Leading, int Trailing) FindMarkers(string input, string openingMarker, string closingMarker)
    {
        int indexOpening = 0;
        int indexClosing = 0;

        indexOpening = input.IndexOf(openingMarker);
        indexClosing = input.IndexOf(closingMarker, indexOpening + 1);

        if (indexOpening != -1 && indexClosing != -1)
        {
            return (indexOpening, indexClosing);
        }
        return (-1, -1);
    }

    private string ReplaceMarkerVariations(string input, string marker)
    {
        input = input.Replace("```csharp", marker);
        input = input.Replace("```Csharp", marker);
        input = input.Replace("```CSharp", marker);
        input = input.Replace("```C#", marker);
        input = input.Replace("```c#", marker);

        return input;
    }
}
