using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    float verticalInput;
    float horizontalInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddRelativeForce(new Vector3(0, verticalInput * speed, 0 ));
        transform.Rotate(Vector3.forward * horizontalInput * rotationSpeed);
    }
}
