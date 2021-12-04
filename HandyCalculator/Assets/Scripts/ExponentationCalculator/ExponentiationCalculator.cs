using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExponentiationCalculator : MonoBehaviour
{
    TextMeshProUGUI resultText;

    [SerializeField] Button equalsButton;

    Button calculationLeft, calculationRight;

    float number1, number2;

    private void Start()
    {
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        calculationLeft = GameObject.Find("CalculationLeft").GetComponent<Button>();
        calculationRight = GameObject.Find("CalculationRight").GetComponent<Button>();


        calculationLeft.onClick.AddListener(Slot1Selected);
        calculationRight.onClick.AddListener(Slot2Selected);

        equalsButton.onClick.AddListener(Calculate);


    }


    private void Calculate()
    {
        number1 = float.Parse(calculationLeft.GetComponentInChildren<TextMeshProUGUI>().text);
        number2 = float.Parse(calculationRight.GetComponentInChildren<TextMeshProUGUI>().text);

        double result = Math.Pow(number2, number1);
        resultText.text = result.ToString();

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
