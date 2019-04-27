using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    void OnTriggerEnter(Collider e)
    {
        if (e.CompareTag("P1"))
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }
}
