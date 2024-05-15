using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Speed of the sphere's movement
    public float speed = 2.0f;

    // Direction of movement (1 for right, -1 for left)
    private int direction = 1;

    void Update()
    {
        // Move the sphere in the current direction
        transform.Translate(direction * speed * Time.deltaTime * Vector3.forward);

        // Check if the sphere has reached the edge of the screen
        if (transform.position.z > -3.5f || transform.position.z < -0f)
        {
            // Reverse the direction of movement
            direction *= -1;
        }
    }
}
