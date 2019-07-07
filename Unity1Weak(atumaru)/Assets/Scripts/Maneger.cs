using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maneger : MonoBehaviour
{
    public static GameObject gameObject;
    private bool go;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject == null)
        {
            gameObject = GameObject.Find("Player");
            go = false;
        }
    }

    // Update is called once per frame
    void Update()
    {



    }
}
