using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsCreate : MonoBehaviour {
    public GameObject animals1;
    public GameObject animals2;
    public GameObject animals3;
    public GameObject Gold;
    public float TimeLimit = 3;
    private float Timer = 0;
 int[] Nums=new int[]{0,1,2};
 private int rn;


	

	void Update () {

        Timer += Time.deltaTime;
        if (TimeLimit <= Timer)
        {
        rn = Nums[Random.Range(0, Nums.Length)];
        switch (rn)
     {
         case 1: Instantiate(animals1, new Vector3(Random.Range(transform.position.x - 1, transform.position.x + 1f), 0.5f, transform.position.z), Quaternion.identity);
             break;
         case 2: Instantiate(animals2, new Vector3(Random.Range(transform.position.x - 1, transform.position.x + 1f), 0.5f, transform.position.z), Quaternion.identity);
             break;
         case 3: Instantiate(animals3, new Vector3(Random.Range(transform.position.x - 1, transform.position.x + 1f), 0.5f, transform.position.z), Quaternion.identity);
             break;}
        Instantiate(Gold, new Vector3(Random.Range(transform.position.x - 0.5f, transform.position.x + 0.5f), 0.5f, transform.position.z + 0.5f), Quaternion.identity);
        Timer = 0;
        }
    }
}
