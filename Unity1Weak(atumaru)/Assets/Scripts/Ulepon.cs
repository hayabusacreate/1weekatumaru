using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ulepon : MonoBehaviour
{
    private FixedJoint fixedJoint;
    //public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            collision.gameObject.transform.parent = transform;
            //Joint();
        }

    }
    void Joint()
    {
        //Player.transform.parent = transform;
    }
}
