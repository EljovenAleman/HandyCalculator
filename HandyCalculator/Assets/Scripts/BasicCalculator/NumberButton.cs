﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberButton : MonoBehaviour
{
    Button button;
    TextMeshProUGUI calculationText;
    
    void Start()
    {
        
        calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(AddNumberToCalculation);
    }        

    void AddNumberToCalculation()
    {
        if(SlotManager.slot == 1)
        {
            Debug.Log("added to slot 1");
            calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        }
        else if(SlotManager.slot == 2)
        {
            Debug.Log("added to slot 2");
            calculationText = GameObject.Find("CalculationRight").GetComponentInChildren<TextMeshProUGUI>();
        }
        calculationText.text = calculationText.text + button.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }
}
