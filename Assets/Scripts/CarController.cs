using UnityEngine;

public partial class CarController : MonoBehaviour
{
    public float speed = 15f;
    public float turnSpeed = 100f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        
        float moveInput = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);

        float turnInput = Input.GetAxis("Horizontal");
        float turn = turnInput * turnSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}