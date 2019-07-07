using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spon : MonoBehaviour
{
    public GameObject[] enemy,ulepon;
    public Vector3[] enemypos;
    public int minX,minZ,maxX,maxZ;
    private int randomX, randomZ, enemyrnd, spornrnd;
    public int spornint,uleponsporn;
   public static int sporncount=0,uleponcount;
    // Start is called before the first frame update
    void Start()
    {
        sporncount = 0;
        uleponcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sporn();
        Usporn();
    }

    void sporn()
    {
        Debug.Log("a");
        if(spornint>=sporncount)
        {
            Debug.Log("b");
            for (int i = spornint; i > 0; i--)
            {
                spornrnd = Random.Range(0, enemypos.Length);
                enemyrnd = Random.Range(0, enemy.Length);
                Instantiate(enemy[0], enemypos[spornrnd], Quaternion.identity);
                sporncount++;
                Debug.Log("c");
            }
        }

    }
    void Usporn()
    {
        if (uleponsporn >= uleponcount)
        {
            Debug.Log("b");
            for (int i = uleponsporn; i > 0; i--)
            {
                randomX = Random.Range(minX, maxX);
                randomZ = Random.Range(minZ, maxZ);
                enemyrnd = Random.Range(0, ulepon.Length);
                Instantiate(ulepon[0], new Vector3(randomX, -0.5f, randomZ), Quaternion.identity);
                uleponcount++;
                Debug.Log("c");
            }
        }
    }
}
