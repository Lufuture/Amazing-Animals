using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class NewBehaviourScript : MonoBehaviour {
    private CharacterController characterController;
    public float tiltAngle = 3.0F;
    float horizontal = 0;  
	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();  
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");  
        if (horizontal < 0.0f)
        {
            transform.Rotate(0, 1, 0);
        }
        if (horizontal > 0.0f)
        {
            transform.Rotate(0, -1, 0);
        }
		
}	}    此为旋转测试脚本*/
public class playControl : MonoBehaviour
{

    private Transform tran;
    //public float tiltAngle = 3.0F;
    float horizontal = 0;  
    public float movespeed = 1f;
    void Start() { 
    tran = GetComponent<Transform>();

    }
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        if (horizontal < 0.0f )   
        {
            transform.Rotate(0, -0.5f, 0);
            
        }
        if (horizontal > 0.0f )
        {
            transform.Rotate(0, 0.5f, 0);
        }
       // if (Input.GetKey(KeyCode.UpArrow))
           // transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);

       // if (Input.GetKey(KeyCode.LeftArrow))
       //transform.Translate(Vector3.left * movespeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.RightArrow))
           // transform.Translate(Vector3.right * movespeed * Time.deltaTime);
    }
}  


