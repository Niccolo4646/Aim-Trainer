using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public List<GameObject> Spheres = new List<GameObject>();
    public AudioSource AudioSourceBoom;

    [SerializeField] public TMP_Text WarningText;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            AudioSourceBoom.Play();
            Destroy(other.gameObject);
            Instantiate(Spheres[Random.Range(0, Spheres.Count)]);
        }  

        if(other.gameObject.CompareTag("BananaHead")) {
            WarningText.text = "HEADSHOT!! +2 PUNTI!";
            Invoke("ClearWarningText", 3f);
        }
    }

    void ClearWarningText()
    {
        WarningText.text = "";
    }
}
