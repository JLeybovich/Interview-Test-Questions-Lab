using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

public class MarkdownConverter
{
    private const int MinHeader = 1;
    private const int MaxHeader = 6;

    public void MarkdownToHtml(
        string inputMarkdownFilePath,
        string outputMarkdownFilePath)
    {
        string input = File.ReadAllText(inputMarkdownFilePath);
        string converted = Convert(input);
        File.WriteAllText(outputMarkdownFilePath, converted);
    }

    private string Convert(string input)
    {
        string converted = input;
        converted = ConvertHeaders(ref converted);
        converted = ConvertFormat(ref converted, 2, "strong");
        converted = ConvertFormat(ref converted, 1, "em");
        return converted;
    }

    private string ConvertHeaders(ref string input)
    {
        for(int header = MaxHeader; header >= MinHeader; --header)
        {
            var pattern = @"^#{" + header + "}.*";
            var matches = Regex.Matches(input, pattern, RegexOptions.Multiline);

            foreach(Match match in matches)
            {
                string converted = Regex.Replace(match.ToString(),
                    @"^#+\s*",
                    "<h" + header + ">");
                converted = Regex.Replace(converted,
                    @"\s*#*$",
                    "");
                converted += "</h" + header + ">";

                input = input.Replace(match.ToString(), converted);
            }
        }

        return input;
    }

    private string ConvertFormat(ref string input, int num, string tag)
    {
        var pattern = "_{" + num + "}.*" + "_{" + num + @"}|\*{" + num + @"}.*\*{"
            + num + "}";
        var matches = Regex.Matches(input, pattern, RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            string converted = Regex.Replace(match.ToString(),
                @"^(_{" + num + @"}|\*{" + num + "})",
                @"<" + tag + ">");
            converted = Regex.Replace(converted,
                @"(_{" + num + @"}|\*{" + num + "})$",
                @"</" + tag + ">");

            input = input.Replace(match.ToString(), converted);
        }

        return input;
    }
}
