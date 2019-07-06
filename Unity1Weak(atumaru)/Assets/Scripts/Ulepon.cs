using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ulepon : MonoBehaviour
{
    public static int ulepon;
    private FixedJoint fixedJoint;
    //public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        ReturnUlepon(0);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Uepon")
        {
            collision.gameObject.transform.parent = transform;
            ulepon++;
            //Joint();
        }

    }
    void Joint()
    {
        //Player.transform.parent = transform;
    }
    public static int GetUlepon()
    {
        return ulepon;
    }
    public static void ReturnUlepon(int reset)
    {
        ulepon = reset;
    }
}
