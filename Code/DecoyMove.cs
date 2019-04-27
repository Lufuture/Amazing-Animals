using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyMove : MonoBehaviour {
    private Rigidbody R;
    public float LinshiSpeed;
	// Use this for initialization
	void Start () {
		R = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        R.velocity = -transform.right * LinshiSpeed;
	}
}
