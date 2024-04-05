using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public TMP_Text SensValueText;
    public Slider SensValueScroll;

    void ChangeSensValueText()
    {
        SensValueText = SensValueScroll.value.ToString();
    }
}
