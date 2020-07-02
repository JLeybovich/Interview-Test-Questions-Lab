using System.IO;
using System.Text.RegularExpressions;

public class MarkdownConverter
{
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
        converted = ConvertAutoEscape(ref converted, '&', "amp");
        converted = ConvertAutoEscape(ref converted, '<', "lt");
        converted = ConvertFormat(ref converted, 2, "strong");
        converted = ConvertFormat(ref converted, 1, "em");
        converted = ConvertParagraphs(ref converted);
        converted = ConvertLists(ref converted, "ul", "[-+*]");
        converted = ConvertLists(ref converted, "ol", @"\d+.");
        converted = ConvertHeaders(ref converted);
        return converted;
    }

    private string ConvertAutoEscape(ref string input, char ch, string sub)
    {
        var pattern = ch == '&' ? @".*(\b&.[^;])" : ch.ToString();
        var matches = Regex.Matches(input, pattern, RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            string converted = Regex.Replace(match.ToString(),
                ch.ToString(),
                @"&" + sub + ";");

            input = input.Replace(match.ToString(), converted);
        }

        return input;
    }

    private string ConvertLists(ref string input, string listTag, string bulletPattern)
    {
        var pattern = @"(" + bulletPattern + @" .*$\n)+";
        var matches = Regex.Matches(input, pattern, RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            pattern = "^" + bulletPattern + @"\s*";
            string converted = Regex.Replace(match.ToString(), pattern,
                x => "<li>",
                RegexOptions.Multiline);
            converted = Regex.Replace(converted, "\n", "</li>\n", RegexOptions.Multiline);

            converted = "<" + listTag + ">\n" +
                converted +
                "</" + listTag + ">\n";

            input = input.Replace(match.ToString(), converted);
        }

        return input;
    }

    private string ConvertHeaders(ref string input, int minHeader = 1, int maxHeader = 6)
    {
        for(int header = maxHeader; header >= minHeader; --header)
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

    private string ConvertParagraphs(ref string input)
    {
        var pattern = @"^(?![#>\+\-*\d ])((?![#>\-*\d ]).+\n?)+";
        input = Regex.Replace(input, pattern, x => "<p>" + x.ToString().TrimEnd('\n') + "</p>\n",
            RegexOptions.Multiline);
        return input;
    }
}
