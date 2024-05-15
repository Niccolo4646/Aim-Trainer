using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{
    public List<GameObject> Spheres; // List of sphere prefabs to spawn

    [Header("Audio Effects")]
    public AudioSource AudioSource;
    public AudioClip Boom;
    public AudioClip Headshot;

    [SerializeField] GameObject[] warningTextObjects;
    private TMP_Text warningText;
    private void Start()
    {
        warningTextObjects = GameObject.FindGameObjectsWithTag("WarningText");
        warningText = warningTextObjects[0].GetComponent<TMP_Text>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            AudioSource.PlayOneShot(Boom);
            Destroy(other.gameObject);
            Instantiate(Spheres[Random.Range(0, Spheres.Count)]);
        }
        if (other.gameObject.CompareTag("BananaHead"))
        {
            warningText.text = "HEADSHOT!!";
            Invoke("ClearWarningText", 3f);

            AudioSource.PlayOneShot(Headshot);
        }
    }

    void ClearWarningText()
    {
        if (warningText != null) // Check if warningText is valid before modifying it
        {
            warningText.text = "";
        }
    }
}
