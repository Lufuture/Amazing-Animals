using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backUPdoor : MonoBehaviour {

    public GameObject player;
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {

            player.transform.Rotate(transform.rotation.x, transform.rotation.y, 30f);
            Destroy(this.gameObject);
        }
    }
}
