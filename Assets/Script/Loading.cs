using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Loading : MonoBehaviour
{
    [SerializeField] Image loadBar;
    float fillPercent = 0.1f;

    public TMP_Text tipText;
    List<string> tipList = new List<string>()
    {
        "Clicca il tasto Sinistro del mouse per sparare",
        "raccogli le monete per ottenere punti bonus!",
        " (aggiungi altri suggerimenti qui)"
    };

    private void Start()
    {
        // RANDOM TIP
        if (tipList.Count == 0)
        {
            Debug.LogError("Tip list is empty. Please add tips to the list.");
        }

        int randomIndex = Random.Range(0, tipList.Count);

        string randomTip = tipList[randomIndex];
        tipText.text = randomTip;
    }

    void FixedUpdate()
    {
        fillPercent += 0.01f;

        fillPercent = Mathf.Clamp(fillPercent, 0f, 1f);

        loadBar.fillAmount = fillPercent;
    }

    private void Update()
    {
        if (fillPercent >= 1)
        {
            Invoke("goToTraining", 1f);
        }
    }

    void goToTraining()
    {
        SceneManager.LoadScene(2);
    }
}
