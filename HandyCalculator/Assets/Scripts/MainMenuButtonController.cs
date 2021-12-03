using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtonController : MonoBehaviour
{
    [SerializeField] Button basicCalculatorButton;

    void Start()
    {
        basicCalculatorButton.onClick.AddListener(SceneRedirector.GoToBasicCalculator);        
    }    
}
