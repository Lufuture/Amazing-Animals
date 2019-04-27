using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updoor : MonoBehaviour {
    public float Angle;
    public GameObject player;
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player")) {

            player.transform.Rotate(transform.rotation.x, transform.rotation.y, Angle);//第一段-30
            Destroy(this.gameObject);
        }
    }
}
