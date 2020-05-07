using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MicrosoftTest : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>

    public class TargetNode
    {
        public char value;
        public List<TargetNode> depedencies;
    }

    public void TraverseAndLog(List<TargetNode> allTargets)
    {
        TargetNode nullRoot = null;

        foreach(var target in allTargets)
        {
            if(target.depedencies == null)
            {
                Debug.Log(target.value);
                nullRoot = target;
                break;
            }
        }

        if(nullRoot == null)
        {
            throw new ArgumentException();
        }

        List<TargetNode> possibleNextTargets = new List<TargetNode>();
        HashSet<char> visited = new HashSet<char>();

        int lowestTargetCount = int.MaxValue;
        TargetNode lowestTarget = null;

        foreach(var target in allTargets)
        {
            if(target.depedencies.Contains(nullRoot))
            {
                possibleNextTargets.Add(target);
            }
        }

        visited.Add(nullRoot.value);

        while(possibleNextTargets.Count > 0)
        {
            TargetNode target = possibleNextTargets[0];
            int depCount = target.depedencies.Count;
            //TargetNode foundTarget = null;

            for(var i = 1; i < possibleNextTargets.Count; ++i)
            {
                var nextTarget = possibleNextTargets[i];

                if(target.depedencies.Count < nextTarget.depedencies.Count)
                {
                    target = nextTarget;
                }
            }

            Debug.Log(target.value);
            visited.Add(target.value);

            possibleNextTargets.Clear();
            foreach (var otherTarget in allTargets)
            {
                if (!visited.Contains(otherTarget.value) && otherTarget.depedencies.Contains(target))
                {
                    possibleNextTargets.Add(otherTarget);
                }
            }
        }
    }
}
