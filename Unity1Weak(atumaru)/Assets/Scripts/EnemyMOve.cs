﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMOve : MonoBehaviour
{
    public GameObject player;
    private Vector3 tragetpos;

    public float speed,rotatspeed;
    public float attenuation;
    private float dis;
    float x, y, z;
    private Rigidbody rigidbody;
    private Shot shot;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RotateMove();

        Move();

    }
    void Move()
    {
        //transform.position += new Vector3(Mathf.Sin(Time.time * speed), 0, Mathf.Cos(Time.time * speed));
        player = GameObject.Find("Player");
        if(player!=null)
        {
            tragetpos += (player.transform.position - transform.position) * speed;
            tragetpos *= attenuation;
            transform.position += tragetpos *= Time.deltaTime;
        }

        //transform.position += new Vector3(Mathf.Sin(Time.time * speed), 0, Mathf.Cos(Time.time * speed));
    }
    void RotateMove()
    {

        player = GameObject.Find("Player");

        if (player != null)
        {
            Vector3 ppos = player.transform.position;
            Vector3 enepos = this.transform.position;
            dis = Vector3.Distance(enepos, ppos);
        }
        //// transform.position += new Vector3(dis * Mathf.Sin(Time.time * rotatspeed), 0, dis * Mathf.Cos(Time.time * rotatspeed));
        // x = dis * Mathf.Sin(Time.time * rotatspeed);
        // z = dis * Mathf.Cos(Time.time * rotatspeed);
        // transform.position = new Vector3(x, 0, z);
        // Debug.Log(dis);
        rigidbody.MovePosition(new Vector3(dis * Mathf.Sin(Time.time * rotatspeed), transform.position.y, dis * Mathf.Cos(Time.time * rotatspeed)));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player"||collision.gameObject.tag=="Uepon")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
        if(collision.gameObject.tag=="Shot")
        {
            spon.sporncount -= 1;
            spon.uleponcount -= 1;
            Destroy(gameObject);

        }
    }
}
