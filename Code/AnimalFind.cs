#pragma warning disable 50
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFind : MonoBehaviour
{
    // Fields
    public GameObject player;

    // Methods
    private void Dropit()
    {
        base.transform.parent = null;
    }

    private void OnTriggerEnter(Collider h)
    {
        if (h.CompareTag("RidingMonster"))
        {
            this.player.SendMessage("ShuaiJiao");
        }
        if (h.CompareTag("Player"))
        {
            Debug.Log("Slow!!!");
            Time.timeScale = 0.7f;
        }
    }

    private void OnTriggerExit(Collider a)
    {
        if (a.CompareTag("Player"))
        {
            Debug.Log("Return");
            Time.timeScale = 1f;
        }
    }

    private void OnTriggerStay(Collider e)
    {
        if (e.CompareTag("Player"))
        {
            Debug.Log("enter");
            Vector3 position = base.gameObject.transform.position;
            this.player.SendMessage("accept", position);
        }
    }

    private void Update()
    {
        if (base.gameObject.transform.parent.parent.CompareTag("Player"))
        {
            Debug.Log("骑了！");
            Object.Destroy(base.gameObject.GetComponent<CapsuleCollider>());
            base.tag = "RidingMonster";
        }
    }
}


