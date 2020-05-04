using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charts : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingChart;

    int[] oddNumbers = { 1, 3, 5, 7, 9 };

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingChart;

        textComponent.text = state.GetStateChart();

        Debug.Log(oddNumbers[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
