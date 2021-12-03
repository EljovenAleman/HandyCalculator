using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SymbolButton : MonoBehaviour
{
    Button button;
    TextMeshProUGUI symbolText;

    void Start()
    {
        symbolText = GameObject.Find("SymbolText").GetComponent<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(AddSymbol);
    }    

    void AddSymbol()
    {
        symbolText.text = button.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }
}
