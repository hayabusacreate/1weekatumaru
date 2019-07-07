using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countTime;
    public static GameObject player;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Count();
    }

    void Count()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示
        if(countTime<=0)
        {

            player = GameObject.Find("Player");
            SceneManager.LoadScene("Result");

        }
    }

}
