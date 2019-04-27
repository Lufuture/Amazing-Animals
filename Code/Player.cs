using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float acceleration;
    public float maxSpeed;
    private Rigidbody rigidBody;
    private KeyCode[] inputKeys;
    private Vector3[] directionsForKeys;
    public float yRotation = 5.0F;
    //public float xRotation = 5.0F;

	void Start () {
        inputKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
        directionsForKeys = new Vector3[] { Vector3.forward, Vector3.right, Vector3.back, Vector3.left };
        rigidBody = GetComponent<Rigidbody>();


	}


    void Update()
    {
        yRotation += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(0, yRotation, 0);
        if (yRotation > 60)

            transform.eulerAngles = new Vector3(0, 60, transform.eulerAngles.z);

        if (yRotation < -60)

            transform.eulerAngles = new Vector3(0, -60, transform.eulerAngles.z);
        
            for (int i = 0; i < inputKeys.Length; i++)
            {
                var key = inputKeys[i];

                // 2
                if (Input.GetKey(key))
                {
                    // 3
                    Vector3 movement = directionsForKeys[i] * acceleration * Time.deltaTime;
                    movePlayer(movement);
                }

            }
        }

    void movePlayer(Vector3 movement)
    {
        if (rigidBody.velocity.magnitude * acceleration > maxSpeed)
        {
            rigidBody.AddForce(movement * -1);
        }
        else
        {
            rigidBody.AddForce(movement);
        }
    }

}
