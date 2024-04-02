using UnityEngine;
using TMPro;

public class CameraMovement : MonoBehaviour
{
    public enum Sens
    {
        First,
        Second,
        Third,
        Fourth
    }
    public Sens currentSensValue;
    [SerializeField] public TMP_Text SensText;

    [SerializeField] GameObject player;
    [SerializeField]
    [Range(0.5f, 2f)]
    float mouseSense = 1;
    [SerializeField]
    [Range(-20, -10)]
    int lookUp = -15;
    [SerializeField]
    [Range(15, 25)]
    int lookDown = 20;

    // Una variabile booleana che tiene traccia dello stato attuale del giocatore.
    public bool isSpectator;
    // Script di volo della telecamera libera
    [SerializeField] float speed = 50f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;

        if (!isSpectator)
        {
            Vector3 rotCamera = transform.rotation.eulerAngles;
            Vector3 rotPlayer = player.transform.rotation.eulerAngles;

            rotCamera.x = (rotCamera.x > 180) ? rotCamera.x - 360 : rotCamera.x;
            rotCamera.x = Mathf.Clamp(rotCamera.x, lookUp, lookDown);
            rotCamera.x -= rotateY;

            rotCamera.z = 0;
            rotPlayer.y += rotateX;

            transform.rotation = Quaternion.Euler(rotCamera);
            player.transform.rotation = Quaternion.Euler(rotPlayer);
        }
        else
        {
            // Ottenere la rotazione corrente della telecamera
            Vector3 rotCamera = transform.rotation.eulerAngles;
            // Modifica della rotazione della telecamera in base al movimento del mouse
            rotCamera.x -= rotateY;
            rotCamera.z = 0;
            rotCamera.y += rotateX;
            transform.rotation = Quaternion.Euler(rotCamera);
            // Lettura della pressione dei tasti WASD 
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            // Impostazione del vettore di movimento della telecamera
            Vector3 dir = transform.right * x + transform.forward * z;
            // Modifica della posizione della telecamera
            transform.position += dir * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Se il cursore del mouse � bloccato, allora...
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                // Sblocco del cursore
                Cursor.lockState = CursorLockMode.None;
            }
            // Altrimenti...
            else
            {
                // Blocco del cursore
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentSensValue = Sens.First;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentSensValue = Sens.Second;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentSensValue = Sens.Third;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentSensValue = Sens.Fourth;
        }

        // Abilitare/disabilitare in base al valore corrente
        switch (currentSensValue)
        {
            case Sens.First:
                mouseSense = 1;
                SensText.text = mouseSense.ToString();
                break;
            case Sens.Second:
                mouseSense = 0.75f;
                SensText.text = mouseSense.ToString();
                break;
            case Sens.Third:
                mouseSense = 0.50f;
                SensText.text = mouseSense.ToString();
                break;
            case Sens.Fourth:
                mouseSense = 0.25f;
                SensText.text = mouseSense.ToString();
                break;
        }
    }
}