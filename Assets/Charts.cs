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
        
    }
}
