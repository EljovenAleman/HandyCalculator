using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtonController : MonoBehaviour
{
    [SerializeField] Button basicCalculatorButton;
    [SerializeField] Button rootsButton;
    [SerializeField] Button exponentiationButton;
    [SerializeField] Button ruleOfThreeButton;
    [SerializeField] Button trigonometry;



    void Start()
    {
        basicCalculatorButton.onClick.AddListener(SceneRedirector.GoToBasicCalculator);
        rootsButton.onClick.AddListener(SceneRedirector.GoToRoots);
        exponentiationButton.onClick.AddListener(SceneRedirector.GoToExponentiation);
        ruleOfThreeButton.onClick.AddListener(SceneRedirector.GoToRuleOfThree);
        trigonometry.onClick.AddListener(SceneRedirector.GoToTrigonometry);
    }    
}
