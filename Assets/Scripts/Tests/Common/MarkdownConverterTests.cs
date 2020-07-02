using System.IO;
using NUnit.Framework;
using UnityEngine;

public class MarkdownConverterTests
{
    private const string DataDirectory = "/Users/joe/git/InterviewTestQuestionsLab/Assets/Data/";
    private const string ExpectedPath = DataDirectory + "Expected.html";
    private const string InputPath = DataDirectory + "Input.md";
    private const string OutputPath = DataDirectory + "Output.html";

    [Test]
    public static void ExampleDriver()
    {
        var converter = new MarkdownConverter();
        var expected = File.ReadAllText(ExpectedPath);
        converter.MarkdownToHtml(InputPath, OutputPath);
        var actual = File.ReadAllText(OutputPath);
        Debug.Log(actual);
        Assert.AreEqual(expected, actual);
    }
}
