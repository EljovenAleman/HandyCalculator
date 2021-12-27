using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasteButton : MonoBehaviour
{
    Button button;
    TextMeshProUGUI calculationText;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PasteCopiedResult);
    }

   void PasteCopiedResult()
    {
        SetCalculationText();

        calculationText.text = PlayerPrefs.GetString("copiedResult");

    }

    private void SetCalculationText()
    {
        if (FindObjectOfType<TrigonometryCalculator>() != null)
        {
            if (SlotManager.slot == 1)
            {
                Debug.Log("added to slot 1");
                calculationText = GameObject.Find("CalculationA").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 2)
            {
                Debug.Log("added to slot 2");
                calculationText = GameObject.Find("CalculationB").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 3)
            {
                Debug.Log("added to slot 3");
                calculationText = GameObject.Find("CalculationX").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 4)
            {
                Debug.Log("added to slot 4");
                calculationText = GameObject.Find("CalculationY").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 5)
            {
                Debug.Log("added to slot 4");
                calculationText = GameObject.Find("CalculationH").GetComponentInChildren<TextMeshProUGUI>();
            }
        }
        else
        {
            if (SlotManager.slot == 1)
            {
                Debug.Log("added to slot 1");
                calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 2)
            {
                Debug.Log("added to slot 2");
                calculationText = GameObject.Find("CalculationRight").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 3)
            {
                Debug.Log("added to slot 3");
                calculationText = GameObject.Find("CalculationBottomLeft").GetComponentInChildren<TextMeshProUGUI>();
            }
            else if (SlotManager.slot == 4)
            {
                Debug.Log("added to slot 4");
                calculationText = GameObject.Find("CalculationBottomRight").GetComponentInChildren<TextMeshProUGUI>();
            }
        }
    }
}
