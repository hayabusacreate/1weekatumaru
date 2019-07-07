using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUlepon : MonoBehaviour
{
    public GameObject gameObject;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = Ulepon.ulepon;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            Instantiate(gameObject, transform.position, Quaternion.identity);
            count--;
        }
    }
}
