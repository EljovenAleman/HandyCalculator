using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetAllButton : MonoBehaviour
{
    List<TextMeshProUGUI> calculationTextList = new List<TextMeshProUGUI>();
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        
        button.onClick.AddListener(ResetAllValues);
    }

    private void ResetAllValues()
    {
        GetTextComponents();
        Debug.Log("Should Reset All Values");
        foreach (TextMeshProUGUI textMesh in calculationTextList)
        {            
            textMesh.text = "0";
        }
    }

    void GetTextComponents()
    {
        var objectsList = GameObject.FindGameObjectsWithTag("CalculationSlot");
        

        foreach(var myGameObject in objectsList)
        {            
            var component = myGameObject.GetComponentInChildren<TextMeshProUGUI>();
            
            calculationTextList.Add(component);                        
        }
    }

    
}
