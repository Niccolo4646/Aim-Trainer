using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaMan : MonoBehaviour
{
    public GameObject boomVFX;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ammo"))
        {
            GameObject vfx = Instantiate(boomVFX, transform.position, transform.rotation);
            ;
            Destroy(vfx, 0.5f);

            gameObject.SetActive(false);
            Invoke(nameof(ActiveBananaMan), 1f);
        }
    }

    void ActiveBananaMan()
    {
        gameObject.SetActive(true);
    }
}
