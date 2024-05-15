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
        "Clicca T per equipaggiare e togliere l'arma",
        "Clicca i tasti 1-4 per modifcare la sensibilità della telecamra"
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
            Invoke("goToHome", 1f);
        }
    }

    void goToHome()
    {
        SceneManager.LoadScene(0);
    }
}
