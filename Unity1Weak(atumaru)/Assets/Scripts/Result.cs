using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("Title");


        }
        ResultUepon();
    }
    void ResultUepon()
    {

        Text scoreText = gameObject.GetComponent<Text>();
        scoreText.text ="総武器数:" +Ulepon.ulepon;
        
    }

}
