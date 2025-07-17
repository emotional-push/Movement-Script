using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            force += transform.forward;
        if (Input.GetKey(KeyCode.S))
            force -= transform.forward;
        if (Input.GetKey(KeyCode.A))
            force -= transform.right;
        if (Input.GetKey(KeyCode.D))
            force += transform.right;

        rb.AddForce(force.normalized * moveForce);
    }
}