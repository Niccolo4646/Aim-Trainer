using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class HomeManager : MonoBehaviour
{
    public void GoToTrainingMode()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene(3);
    }
}
