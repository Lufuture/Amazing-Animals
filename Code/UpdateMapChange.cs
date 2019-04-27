using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpdateMapChange : MonoBehaviour
{
    GameObject bg5;
    private bool huan5 = false;
    public GameObject ditu215;
    public GameObject ditu225;
    private float timer;
    public float C =0;
    void Start()
    {
        bg5 = new GameObject();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 30)
        {
            huan5 = true;
        }
    }

    void OnTriggerEnter(Collider e)
    {
        if (e.CompareTag("Player"))
        {
            Debug.Log("碰撞发生");
            if (huan5 == true)   //计算时间到，开始执行第二段地图
            {
                    Debug.Log("执行更换地图2");
                    if (gameObject.transform.parent.CompareTag("bg2") || gameObject.transform.parent.CompareTag("bg1"))//父类  
                    {
                        Debug.Log("215移动！");
                        bg5 = GameObject.FindGameObjectWithTag("bg1");
                        ditu215.transform.position = new Vector3(bg5.transform.position.x, bg5.transform.position.y, bg5.transform.position.z - 37.00f);
                        bg5 = GameObject.FindGameObjectWithTag("bg2" );
                        ditu225.transform.position = new Vector3(bg5.transform.position.x, bg5.transform.position.y, bg5.transform.position.z - 37.00f);
                     }
                else 
                {
                    if (gameObject.transform.parent.CompareTag("P1"))//父类  
                    {
                        Debug.Log("此时进入正轨开始交替移动第二段地图");
                        ditu225.transform.position = new Vector3(0, 0, ditu215.transform.position.z - 37.00f);
                    }
                    else
                    {
                        ditu215.transform.position = new Vector3(0, 0, ditu225.transform.position.z - 37.00f);
                    }
                }
            }
            else
            {
                Debug.Log("执行地图1");//第一段
                if (gameObject.transform.parent.CompareTag("bg2"))//父类  
                {
                    bg5 = GameObject.FindGameObjectWithTag("bg1");
                    bg5.transform.position = new Vector3(bg5.transform.position.x + 0.26f, 0, bg5.transform.position.z - 75.2201f);
                }
                else
                {
                    bg5 = GameObject.FindGameObjectWithTag("bg2");
                    bg5.transform.position = new Vector3(bg5.transform.position.x + 0.26f, 0, bg5.transform.position.z - 75.2201f);
                }
            }
        }
    }





}