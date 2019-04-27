using UnityEngine;  
using System.Collections;  
  
public class TimeSlow : MonoBehaviour {  
  

  
    float timeScaleDelta = .05f;  
  
    // Use this for initialization  
    void Start () {  

    }  
      
    // Update is called once per frame  
    void Update () {  

        float spX = Input.GetAxis("Horizontal");  
        float spY = Input.GetAxis("Vertical");  
        // spX, spY 处理上下左右  
  
        if (Input.GetKeyDown(KeyCode.W)) // 按下W时，把子弹时间加速播放  
        {  
            Time.timeScale += timeScaleDelta;  
        }  
        else if (Input.GetKeyDown(KeyCode.S)) // 按下S时，把子弹时间减速播放  
        {  
            if (Time.timeScale < 0) Time.timeScale = 0;  
            else Time.timeScale -= timeScaleDelta;  
        }  
    }  
  
    void FixedUpdate()  
    {  

    }  
  
 
}  