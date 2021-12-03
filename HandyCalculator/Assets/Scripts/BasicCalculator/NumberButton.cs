using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberButton : MonoBehaviour
{
    Button button;
    TextMeshProUGUI calculationText;
    BasicCalculator calculator;

    void Start()
    {
        calculator = FindObjectOfType<BasicCalculator>();
        calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(AddNumberToCalculation);
    }        

    void AddNumberToCalculation()
    {
        if(calculator.slot == 1)
        {
            calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        }
        else if(calculator.slot == 2)
        {
            calculationText = GameObject.Find("CalculationRight").GetComponentInChildren<TextMeshProUGUI>();
        }
        calculationText.text = calculationText.text + button.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }
}
