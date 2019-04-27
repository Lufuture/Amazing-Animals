using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinbi : MonoBehaviour {
           public GameObject U;
           public int score;

        void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("RidingMonster") || collider.CompareTag("Player"))
        {

            U.SendMessage("AutoAdd");

            Destroy(this.gameObject);
            score1();
            PlayerPrefs.SetInt("score", score);
            PlayerPrefs.Save();

        }
    }
        public void score1() {
            score++;
            Debug.Log(score);
        }
}


