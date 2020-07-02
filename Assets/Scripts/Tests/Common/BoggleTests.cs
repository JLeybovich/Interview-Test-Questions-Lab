using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BoggleTests
{
    private static HashSet<string> legalWords = new HashSet<string>()
    {
       "abed", "abo", "aby", "aero", "aery", "bad", "bade", "be", "bead", "bed", "boa",
       "board", "bore", "bored", "box", "boy", "bread", "bred", "bro", "broad", "byre", "byroad",
       "dab", "deb", "derby", "dev", "dove", "oba", "obe", "orb", "orbed", "orby", "ore",
       "oread", "read", "reb", "red", "rev", "road", "rob", "robbed", "robber",
       "robe", "robed", "verb", "very", "yob", "yore"
    };

    private static HashSet<string> expected = new HashSet<string>()
    {
       "abed", "abo", "aby", "aero", "aery", "bad", "bade", "bead", "bed", "boa",
       "bore", "bored", "box", "boy", "bread", "bred", "bro", "broad", "byre", "byroad",
       "dab", "deb", "derby", "dev", "oba", "obe", "orb", "orbed", "orby", "ore",
       "oread", "read", "reb", "red", "rev", "road", "rob", "robe", "robed",
       "verb", "very", "yob", "yore"
    };

    [Test]
    public static void ExampleDriver()
    {
        Boggle myBoggle = new Boggle();
        HashSet<string> myResults;

        myBoggle.SetLegalWords(legalWords);
        myResults = myBoggle.SolveBoard(3, 3, "yoxrbaved") as HashSet<string>;

        foreach(var word in myResults)
        {
            Debug.Log(word);
            Assert.That(expected.Contains(word), word + " was not expected");
        }

        foreach (var word in expected)
        {
            Assert.That(myResults.Contains(word), word + " was not returned");
        }
    }
}
