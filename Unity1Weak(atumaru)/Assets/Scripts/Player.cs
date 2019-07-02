using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public int Hp;
    private bool deathflag;
    public float speed;
    public bool shotflag;
    public float shottime;
    private float shotdiley;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        shot();
        Death();
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        this.transform.position += new Vector3(x * speed, 0, y * speed);
        //rigidbody.AddForce(x*speed, 0, y*speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Hp--;
        }
    }
    void Death()
    {
        if (Hp <= 0)
        {
            deathflag = true;
        }
    }
    void shot()
    {
        if(Input.GetKey(KeyCode.Space)&&shotflag==false)
        {
            shotflag = true;
        }
        if(shotflag==true)
        {
            if(shotdiley >= shottime)
            {
                shotflag = false;
                shotdiley = 0;
            }else
            {
                shotdiley++;
            }

        }

    }
}
