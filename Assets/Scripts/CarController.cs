using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration = 1200f;
    public float maxSpeed = 50f;
    public float turnSpeed = 100f;
    public float brakeForce = 3000f;

    private Rigidbody rb;
    private float moveInput;
    private float turnInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, -0.5f, 0); // Abbassa baricentro per non ribaltarsi
    }

    void Update()
    {
        moveInput = Input.GetAxis("Vertical"); // W-S o freccia su/giù
        turnInput = Input.GetAxis("Horizontal"); // A-D o frecce sx/dx

        // Frenata con spazio
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(-rb.linearVelocity.normalized * brakeForce * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Accelera solo se sotto velocità massima
        if (rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.forward * moveInput * acceleration * Time.fixedDeltaTime);
        }

        // Sterza solo se la macchina si muove
        if (rb.linearVelocity.magnitude > 1f)
        {
            float turn = turnInput * turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }
}