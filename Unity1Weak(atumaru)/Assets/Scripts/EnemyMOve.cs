using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMOve : MonoBehaviour
{
    public GameObject player;
    private Vector3 tragetpos;

    public float speed,rotatspeed;
    public float attenuation;
    private float dis;
    float x, y, z;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
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

        tragetpos += (player.transform.position - transform.position) * speed;
        tragetpos *= attenuation;
        transform.position += tragetpos *= Time.deltaTime;
        //transform.position += new Vector3(Mathf.Sin(Time.time * speed), 0, Mathf.Cos(Time.time * speed));
    }
    void RotateMove()
    {
        Vector3 ppos = player.transform.position;
        Vector3 enepos = this.transform.position;
        dis = Vector3.Distance(enepos, ppos);

        //// transform.position += new Vector3(dis * Mathf.Sin(Time.time * rotatspeed), 0, dis * Mathf.Cos(Time.time * rotatspeed));
        // x = dis * Mathf.Sin(Time.time * rotatspeed);
        // z = dis * Mathf.Cos(Time.time * rotatspeed);
        // transform.position = new Vector3(x, 0, z);
        // Debug.Log(dis);
        rigidbody.MovePosition(new Vector3(dis * Mathf.Sin(Time.time * rotatspeed), transform.position.y, dis * Mathf.Cos(Time.time * rotatspeed)));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="player")
        {
            Destroy(gameObject);
        }
    }
}
