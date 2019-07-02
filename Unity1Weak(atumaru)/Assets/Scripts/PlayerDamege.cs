using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamege : MonoBehaviour
{
    public int Hp;
    private bool deathflag; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            Hp--;
        }
    }
    void Death()
    {
        if(Hp<=0)
        {
            deathflag = true;
        }
    }
}
