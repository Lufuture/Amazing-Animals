﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = target.position - this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position - offset;
    }
}