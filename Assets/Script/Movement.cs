using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    /* Movimento */
    [Header("Movement")]
    Rigidbody rb;
    Vector3 directon;
    [SerializeField] int currentSpeed;

    /* Salto */
    [Header("Jump")]
    bool isGrounded;
    [SerializeField] float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = 8;
        } else
        {
            currentSpeed = 5;
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        directon = new Vector3(moveHorizontal, 0.0f, moveVertical);
        directon = transform.TransformDirection(directon);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
        }
        print(isGrounded);

        /* Tornare alla schermata home */
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + directon * currentSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;

        if (other.gameObject.CompareTag("trasp"))
        {
            isGrounded = true;
        }
    }
}
