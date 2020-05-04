﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [TextArea (10,14)][SerializeField] string chartText;
    [SerializeField] State[]  nextStates;

    public string GetStateChart()
    {
        return chartText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
        
}

