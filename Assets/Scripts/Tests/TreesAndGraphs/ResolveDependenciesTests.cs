using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class ResolveDependenciesTests
    {
        [Test]
        public void ResolveDependenciesTest()
        {
            var graphNodes = new List<GraphNode<char>>();
            var A = new GraphNode<char>('A');
            var B = new GraphNode<char>('B');
            var C = new GraphNode<char>('C');
            var D = new GraphNode<char>('D');
            var E = new GraphNode<char>('E');
            var F = new GraphNode<char>('F');
            var G = new GraphNode<char>('G');
            var H = new GraphNode<char>('H');
            var I = new GraphNode<char>('I');
            var J = new GraphNode<char>('J');

            A.AddAdjacent(C, D, H);
            B.AddAdjacent(D, E, I);
            C.AddAdjacent(F);
            D.AddAdjacent(F, G);
            E.AddAdjacent(G);
            F.AddAdjacent(H);
            G.AddAdjacent(I);
            H.AddAdjacent(J);
            I.AddAdjacent(J);

            graphNodes.Add(A);
            graphNodes.Add(B);
            graphNodes.Add(C);
            graphNodes.Add(D);
            graphNodes.Add(E);
            graphNodes.Add(F);
            graphNodes.Add(G);
            graphNodes.Add(H);
            graphNodes.Add(I);
            graphNodes.Add(J);

            var result = GraphExtensions.ResolveDependencies(graphNodes);
            string output = "";
            foreach(var ch in result)
            {
                output += ch + " ";
            }
            Debug.Log(output);
        }
    }
}