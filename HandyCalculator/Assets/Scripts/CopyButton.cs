using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CopyButton : MonoBehaviour
{
    TextMeshProUGUI resultText;
    Button button;

    void Start()
    {
        resultText = GameObject.Find("ResultText").GetComponent<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(CopyResult);
    }

    void CopyResult()
    {
        PlayerPrefs.SetString("copiedResult", resultText.text);
        Debug.Log(PlayerPrefs.GetString("copiedResult"));
    }

    
}
