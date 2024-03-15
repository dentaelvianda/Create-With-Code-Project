using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    float horizontalInput;
    float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We move car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardInput);
        //We rotate/steer the car left and right within Y-Axis
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
