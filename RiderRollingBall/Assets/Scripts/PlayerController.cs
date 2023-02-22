using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void onMove(InputValue movementValue)
    {
        // Function body
        Vector2 movementVector = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.AddForce(movementVector);
    }
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
