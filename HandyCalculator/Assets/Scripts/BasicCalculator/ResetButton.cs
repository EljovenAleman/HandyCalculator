using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    Button button;
    TextMeshProUGUI calculationText;
    
    void Start()
    {        
        calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ResetNumber);
    }

    void ResetNumber()
    {
        if (SlotManager.slot == 1)
        {
            calculationText = GameObject.Find("CalculationLeft").GetComponentInChildren<TextMeshProUGUI>();
        }
        else if (SlotManager.slot == 2)
        {
            calculationText = GameObject.Find("CalculationRight").GetComponentInChildren<TextMeshProUGUI>();
        }
        calculationText.text = "0";
    }
}
