using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrigonometryCalculator : MonoBehaviour
{    
    [SerializeField] Button equalsButton;

    Button calculationA, calculationB, calculationX, calculationY, calculationH;

    double numberA, numberB, numberX, numberY, numberH;

    private void Start()
    {
        
        calculationA = GameObject.Find("CalculationA").GetComponent<Button>();
        calculationB = GameObject.Find("CalculationB").GetComponent<Button>();
        calculationX = GameObject.Find("CalculationX").GetComponent<Button>();
        calculationY = GameObject.Find("CalculationY").GetComponent<Button>();
        calculationH = GameObject.Find("CalculationH").GetComponent<Button>();



        calculationA.onClick.AddListener(Slot1Selected);
        calculationB.onClick.AddListener(Slot2Selected);
        calculationX.onClick.AddListener(Slot3Selected);
        calculationY.onClick.AddListener(Slot4Selected);
        calculationH.onClick.AddListener(Slot5Selected);

        equalsButton.onClick.AddListener(Calculate);
        
    }
    private void Calculate()
    {        
        string scenario = GetCaseScenario();

        CalculateScenario(scenario);

        WriteAllNumbers();
        

    }

    private void WriteAllNumbers()
    {
        Debug.Log("Should Write All Numbers");
        
        calculationY.GetComponentInChildren<TextMeshProUGUI>().text = numberY.ToString("0.00");
        calculationX.GetComponentInChildren<TextMeshProUGUI>().text = numberX.ToString("0.00");
        calculationA.GetComponentInChildren<TextMeshProUGUI>().text = numberA.ToString("0.00");
        calculationB.GetComponentInChildren<TextMeshProUGUI>().text = numberB.ToString("0.00");
        calculationH.GetComponentInChildren<TextMeshProUGUI>().text = numberH.ToString("0.00");


    }

    private void CalculateScenario(string scenario)
    {
        if(scenario == "BH")
        {                        
            numberY = numberH * Math.Sin(Math.PI * numberB / 180);
            numberX = numberH * Math.Cos(Math.PI * numberB / 180);
            numberA = 180 - 90 - numberB;            
        }
        else if (scenario == "AH")
        {
            numberY = numberH * Math.Cos(Math.PI * numberA / 180);
            numberX = numberH * Math.Sin(Math.PI * numberA / 180);
            numberB = 180 - 90 - numberA;
        }
        else if(scenario == "AY")
        {
            numberX = numberY * Math.Tan(Math.PI * numberA / 180);
            numberH = Math.Sqrt(Math.Pow(numberX,2) + Math.Pow(numberY, 2));
            numberB = 180 - 90 - numberA;
        }
        else if (scenario == "BY")
        {
            numberA = 180 - 90 - numberB;
            numberX = numberY * Math.Tan(Math.PI * numberA / 180);
            numberH = Math.Sqrt(Math.Pow(numberX, 2) + Math.Pow(numberY, 2));
        }
        else if (scenario == "AX")
        {
            numberB = 180 - 90 - numberA;
            numberY = numberX * Math.Tan(Math.PI * numberB / 180);
            numberH = Math.Sqrt(Math.Pow(numberX, 2) + Math.Pow(numberY, 2));
        }
        else if (scenario == "BX")
        {
            numberY = numberX * Math.Tan(Math.PI * numberB / 180);
            numberH = Math.Sqrt(Math.Pow(numberX, 2) + Math.Pow(numberY, 2));
            numberA = 180 - 90 - numberB;
        }


    }

    private string GetCaseScenario()
    {
        string scenario = "G";
        //Angulos
        if(calculationA.GetComponentInChildren<TextMeshProUGUI>().text != "0")
        {
            numberA = int.Parse(calculationA.GetComponentInChildren<TextMeshProUGUI>().text);
            scenario = "A";
        }
        else if(calculationB.GetComponentInChildren<TextMeshProUGUI>().text != "0")
        {
            numberB = int.Parse(calculationB.GetComponentInChildren<TextMeshProUGUI>().text);
            scenario = "B";
        }

        //Lados
        if (calculationX.GetComponentInChildren<TextMeshProUGUI>().text != "0")
        {
            numberX = int.Parse(calculationX.GetComponentInChildren<TextMeshProUGUI>().text);
            scenario += "X";
        }
        else if (calculationY.GetComponentInChildren<TextMeshProUGUI>().text != "0")
        {
            numberY = int.Parse(calculationY.GetComponentInChildren<TextMeshProUGUI>().text);
            scenario += "Y";
        }
        else if (calculationH.GetComponentInChildren<TextMeshProUGUI>().text != "0")
        {
            numberH = int.Parse(calculationH.GetComponentInChildren<TextMeshProUGUI>().text);
            scenario += "H";
        }


        return scenario;
    }





    private void Slot1Selected()
    {
        SlotManager.slot = 1;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
    private void Slot2Selected()
    {
        SlotManager.slot = 2;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
    private void Slot3Selected()
    {
        SlotManager.slot = 3;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
    private void Slot4Selected()
    {
        SlotManager.slot = 4;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
    private void Slot5Selected()
    {
        SlotManager.slot = 5;
        Debug.Log("Slot selected: " + SlotManager.slot);
    }
}


