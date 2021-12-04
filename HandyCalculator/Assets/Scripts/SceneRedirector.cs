using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneRedirector
{    
    public static void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public static void GoToBasicCalculator()
    {
        SceneManager.LoadScene(1);
    }

    public static void GoToRoots()
    {
        SceneManager.LoadScene(2);
    }

    public static void GoToExponentiation()
    {
        SceneManager.LoadScene(3);
    }

    public static void GoToRuleOfThree()
    {
        SceneManager.LoadScene(4);
    }
}
