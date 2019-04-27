using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndFind : MonoBehaviour
{
    // Fields
    private Animator AA;
    public GameObject animals;
    private Collider BodyCollider;
    private bool CRR;
    private bool fuhuo;
    private bool IsRiding;
    private bool IsWaitngQi;
    public GameObject jieshukuang;
    public GameObject JinDouYun;
    public GameObject jishiqi;
    public float JumpDistance;
    private bool Jumping;
    public float JumpSpeed;
    public float ManSpeed;
    public float margin;
    private Rigidbody rig;
    private float times;
    public float timesl = 3f;
    public GameObject Music;

    // Methods
    private void accept(Vector3 ap)
    {
        Debug.Log("Accept");
        if (this.IsWaitngQi && !this.IsRiding)
        {
            ap += new Vector3(0f, 0.1f, 0.2f);
            base.transform.position = ap;
            this.IsRiding = true;
            this.Jumping = false;
        }
    }

    private void Again()
    {
    }

    private void CanRuning()
    {
        Debug.Log("runing");
        this.CRR = true;
    }

    private void Drop()
    {
        base.gameObject.BroadcastMessage("Dropit");
    }

    private void fall()
    {
        this.rig.AddForce(0f, -5f, 0f);
    }

    private void Jump()
    {
        if (!this.Jumping || !this.IsWaitngQi)
        {
            Debug.Log("Jump");
            this.rig.AddForce((Vector3)(base.transform.up * this.JumpSpeed));
            this.rig.AddForce((Vector3)(-base.transform.right * this.JumpDistance));
            this.rig.useGravity = true;
            this.Jumping = true;
            this.IsRiding = false;
        }
    }

    private void noCanRuning()
    {
        Debug.Log("stopruning");
        this.CRR = false;
    }

    private void P()
    {
        Music.SetActive(false);
        this.JinDouYun.SetActive(true);
        this.jieshukuang.SetActive(true);
        this.jishiqi.SendMessage("stop");
    }

    private void pro()
    {
        this.times += Time.deltaTime;
        if (this.times >= this.timesl)
        {
        }
    }

    private void ShuaiJiao()
    {
        this.Drop();
        this.AA.SetTrigger("Jbad");
    }

    private void Start()
    {
        this.AA = base.GetComponent<Animator>();
        this.BodyCollider = base.GetComponent<BoxCollider>();
        this.rig = base.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.logger.logEnabled = false;
        if (base.transform.eulerAngles.y > 310f)
        {
            base.transform.eulerAngles = new Vector3(0f, 310f, base.transform.eulerAngles.z);
        }
        if (base.transform.eulerAngles.y < 220f)
        {
            base.transform.eulerAngles = new Vector3(0f, 220f, base.transform.eulerAngles.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("get mouse button down!");
            this.IsWaitngQi = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Pressed left click.");
            this.IsWaitngQi = false;
        }
        if (this.CRR)
        {
            this.rig.velocity = (Vector3)(-base.transform.right * this.ManSpeed);
        }
        if (this.CRR && Input.GetMouseButtonUp(0))
        {
            Debug.Log("Drop the Animal");
            this.rig.velocity = (Vector3)(-base.transform.right * 0f);
            this.CRR = false;
            this.Drop();
        }
    }
}


