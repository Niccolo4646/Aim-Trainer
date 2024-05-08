using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject AmmoPrefab;

    public AudioSource audiosource;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject ammoInstance = Instantiate(AmmoPrefab, transform.position, transform.rotation);
            ammoInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 20, ForceMode.Impulse);
            ammoInstance.transform.Rotate(90, transform.rotation.y, transform.rotation.z);

            audiosource.Play();

            Destroy(ammoInstance, 5f);
        }
    }
}
