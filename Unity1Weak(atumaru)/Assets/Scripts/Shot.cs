﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shot();
    }
   public void shot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gameObject, transform.position, transform.rotation);
        }
    }
}
