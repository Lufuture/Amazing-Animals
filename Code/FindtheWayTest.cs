#pragma warning disable 20
#pragma warning disable 21
using UnityEngine;
using System.Collections;
using UnityEngine.AI;  

public class FindtheWayTest : MonoBehaviour
{
    public Transform TargetObject1;

     public Transform TargetObject2;
     public Transform PlayerDecoy;
     private float where; 
     private NavMeshAgent m;
    void Start()
    {

        m = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        m.destination = PlayerDecoy.position;
        //m.destination = TargetObject1.position;
          /*  if (m.transform.position == TargetObject2.transform.position)
            {
                m.destination = TargetObject1.transform.position;

            }*/

            //if (where == 1)
            //{
               
        /*if(m.transform.position==TargetObject1.transform.position){
        m.destination = TargetObject2.transform.position;
        
        }*/
    //}
    }
    void OnTriggerStay(Collider h)
    {
        if (h.CompareTag("P1"))
        {
            Debug.Log("InP1");
            where = 1;
        }
    }
}