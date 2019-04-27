using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RideAndfather : MonoBehaviour
{
    // Fields
    public Transform parent;

    // Methods
    private void OnTriggerEnter(Collider h)
    {
        if (h.CompareTag("P1"))
        {
            Debug.Log("Destroy");
            Object.Destroy(base.gameObject);
        }
        if (h.CompareTag("Player"))
        {
            Debug.Log("ride");
            base.transform.SetParent(this.parent, true);
            base.GetComponent<NavMeshAgent>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").SendMessage("CanRuning");
        }
    }
}

 
 
