using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    [Header("SensSttings")]
    public TMP_Text SensValueText;
    public Slider SensValueScroll;
    float sensValueWhenChange;

    public void WhenUpdateSensValue()
    {
        SensValueText.text = SensValueScroll.value.ToString("F2");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
