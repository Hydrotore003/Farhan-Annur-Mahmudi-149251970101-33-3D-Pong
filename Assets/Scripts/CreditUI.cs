using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditUI : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }

    public void GitHub()
    {
        Application.OpenURL("https://github.com/Hydrotore003");
    }
}
