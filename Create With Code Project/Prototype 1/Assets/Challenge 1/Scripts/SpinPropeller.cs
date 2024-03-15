using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Reference to the propeller component
    public GameObject propeller;
    // Set the rotation speed
    public float rotationSpeed = 10f;
    // Set the propeller rotation
    Vector3 rotationSpin = new Vector3(0, 0, 10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the propeller
        transform.Rotate(rotationSpin* Time.deltaTime *rotationSpeed);
    }
}
