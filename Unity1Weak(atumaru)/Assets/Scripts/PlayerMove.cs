using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        this.transform.position += new Vector3(x*speed, 0, y*speed); 
        //rigidbody.AddForce(x*speed, 0, y*speed);
    }
}
