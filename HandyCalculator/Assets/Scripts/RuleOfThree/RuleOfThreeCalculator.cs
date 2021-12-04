using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuleOfThreeCalculator : MonoBehaviour
{
    TextMeshProUGUI resultText;

    [SerializeField] Button equalsButton;

    Button calculationLeft, calculationRight, calculationBottomLeft, calculationBottomRight;

    float number1, number2, number3;

    private void Start()
    {
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        calculationLeft = GameObject.Find("CalculationLeft").GetComponent<Button>();
        calculationRight = GameObject.Find("CalculationRight").GetComponent<Button>();
        calculationBottomLeft = GameObject.Find("CalculationBottomLeft").GetComponent<Button>();
        calculationBottomRight = GameObject.Find("CalculationBottomRight").GetComponent<Button>();



        calculationLeft.onClick.AddListener(Slot1Selected);
        calculationRight.onClick.AddListener(Slot2Selected);
        calculationBottomLeft.onClick.AddListener(Slot3Selected);
        calculationBottomRight.onClick.AddListener(Slot4Selected);

        equalsButton.onClick.AddListener(Calculate);


    }
    private void Calculate()
    {
        number1 = float.Parse(calculationLeft.GetComponentInChildren<TextMeshProUGUI>().text);
        number2 = float.Parse(calculationRight.GetComponentInChildren<TextMeshProUGUI>().text);

        float result = 0;

        if(calculationBottomLeft.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {
            Debug.Log("la x esta en bottom left");
            number3 = float.Parse(calculationBottomRight.GetComponentInChildren<TextMeshProUGUI>().text);
            result = (number1 * number3) / number2;
        }
        else if(calculationBottomRight.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {
            Debug.Log("la x esta en bottom right");
            number3 = float.Parse(calculationBottomLeft.GetComponentInChildren<TextMeshProUGUI>().text);
            result = (number2 * number3) / number1;
        }


        resultText.text = result.ToString();

    }


    private void Slot4Selected()
    {
        SlotManager.slot = 4;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }

    private void Slot3Selected()
    {
        SlotManager.slot = 3;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }

    private void Slot2Selected()
    {
        SlotManager.slot = 2;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }

    private void Slot1Selected()
    {
        SlotManager.slot = 1;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
}


