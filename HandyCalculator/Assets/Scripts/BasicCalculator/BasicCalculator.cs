using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BasicCalculator : MonoBehaviour
{
    TextMeshProUGUI resultText, symbolText;

    [SerializeField] Button equalsButton;

    Button calculationLeft, calculationRight;

    float number1, number2;

    public int slot = 1;

    private void Start()
    {
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        calculationLeft = GameObject.Find("CalculationLeft").GetComponent<Button>();
        calculationRight = GameObject.Find("CalculationRight").GetComponent<Button>();
        symbolText = GameObject.Find("SymbolText").GetComponent<TextMeshProUGUI>();

        calculationLeft.onClick.AddListener(Slot1Selected);
        calculationRight.onClick.AddListener(Slot2Selected);

        equalsButton.onClick.AddListener(Calculate);
        /*plusButton.onClick.AddListener(AddNumbers);
        minusButton.onClick.AddListener(RestNumbers);
        multiplicationButton.onClick.AddListener(MultiplyNumbers);
        divisionButton.onClick.AddListener(DivideNumbers);*/
    }

    private void Calculate()
    {
        number1 = float.Parse(calculationLeft.GetComponentInChildren<TextMeshProUGUI>().text);
        number2 = float.Parse(calculationRight.GetComponentInChildren<TextMeshProUGUI>().text);

        if(symbolText.text == "+")
        {
            AddNumbers();
        }
        else if(symbolText.text == "-")
        {
            RestNumbers();
        }
        else if (symbolText.text == "X")
        {
            MultiplyNumbers();
        }
        else if (symbolText.text == "/")
        {
            DivideNumbers();
        }
    }

    private void Slot2Selected()
    {
        slot = 2;
        Debug.Log("Slot selected: " + slot);
    }

    private void Slot1Selected()
    {
        slot = 1;
        Debug.Log("Slot selected: " + slot);
    }

    private void DivideNumbers()
    {
        float result = number1 / number2;
        resultText.text = result.ToString();
    }

    private void MultiplyNumbers()
    {
        float result = number1 * number2;
        resultText.text = result.ToString();
    }

    private void RestNumbers()
    {
        float result = number1 - number2;
        resultText.text = result.ToString();
    }

    private void AddNumbers()
    {
        float result = number1 + number2;
        resultText.text = result.ToString();
    }
}
