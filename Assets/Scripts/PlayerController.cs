using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    public float rotationspeed = 25.0f;
    public float verticalInput;
    public float horizontalInput;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.forward);
        // We turn the vehicle
        transform.Rotate(Vector3.left, rotationspeed * verticalInput * Time.deltaTime);
    }
}
