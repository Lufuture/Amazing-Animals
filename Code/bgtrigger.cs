using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bgtrigger : MonoBehaviour
{
    GameObject bg;
    private bool huan = false;
    public GameObject ditu21;
    public GameObject ditu22;
    void Start()
    {
        bg = new GameObject();
    }

    void huanhuan() {
        huan = true;
    }

    void OnTriggerEnter(Collider e)
    {
        if (e.CompareTag("Player"))
        {
            if (huan == true)   //计算时间到，开始执行第二段地图
            {
                if (gameObject.transform.parent.CompareTag("bg2"))//父类  
                {
                    bg = GameObject.FindGameObjectWithTag("bg1");

                    ditu21.transform.position = new Vector3(bg.transform.position.x, bg.transform.position.y, bg.transform.position.z - 69.4201f);
                }
                else
                {
                    bg = GameObject.FindGameObjectWithTag("bg2");
                    ditu22.transform.position = new Vector3(bg.transform.position.x, bg.transform.position.y, bg.transform.position.z - 69.4201f);
                }
            }
            else{              //第一段
                if (gameObject.transform.parent.CompareTag("bg2"))//父类  
                {
                    bg = GameObject.FindGameObjectWithTag("bg1");
                    bg.transform.position = new Vector3(bg.transform.position.x -0.26f, 0, bg.transform.position.z - 80.4201f);
                }
                else
                {
                    bg = GameObject.FindGameObjectWithTag("bg2");
                    bg.transform.position = new Vector3(bg.transform.position.x - 0.26f, 0, bg.transform.position.z - 80.4201f);
                }
                }
        }
    }





}