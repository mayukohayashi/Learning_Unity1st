using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charts : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingChart;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingChart;
        textComponent.text = state.GetStateChart();

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        // このvarはState[]である
        var nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.A))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            state = nextStates[1];
        }
        textComponent.text = state.GetStateChart();
    }
}
