using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody attached to " + gameObject.name + ". PlayerMovement requires a Rigidbody component.");
        }
    }

    void FixedUpdate()
    {
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            force += transform.forward;
        if (Input.GetKey(KeyCode.S))
            force -= transform.forward;
        if (Input.GetKey(KeyCode.A))
        if (force != Vector3.zero)
            rb.AddForce(force.normalized * moveForce);
        if (Input.GetKey(KeyCode.D))
            force += transform.right;

        rb.AddForce(force.normalized * moveForce);
    }
}