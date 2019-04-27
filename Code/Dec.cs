using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dec : MonoBehaviour {

    public Transform Player;
	
	// Update is called once per frame
	void Update () {
        //transform.position= Player.position - new Vector3(0,0,3);
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.position.z - 9);

	}
}
