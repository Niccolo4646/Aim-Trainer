using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunOnLoading : MonoBehaviour
{
    private void FixedUpdate()
    {
        float currentRotationY = transform.rotation.eulerAngles.y;

        // Calcola la nuova rotazione Y
        float newRotationY = currentRotationY + 5f;

        // Crea una rotazione con la nuova rotazione Y
        Quaternion rotation = Quaternion.Euler(0f, newRotationY, 0f);

        // Applica la rotazione al GameObject        
        transform.rotation = rotation;
    }
}
