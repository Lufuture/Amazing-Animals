using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDH : MonoBehaviour {
    public GameObject JinDouYun;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        //JinDouYun.SetActive(false);
		Player.SetActive (false);
        Time.timeScale = 1;

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            //JinDouYun.SetActive(true);
        
        }
	}
    void Des() {
        Player.SetActive(true);
        JinDouYun.SetActive(false) ;
    }
}

