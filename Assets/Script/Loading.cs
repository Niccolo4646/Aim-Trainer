using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] Image loadBar;
    float fillPercent = 0.1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        fillPercent += 0.01f; // Increase fill amount gradually

        // Clamp fillPercent between 0 and 1 to avoid exceeding the bar
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
