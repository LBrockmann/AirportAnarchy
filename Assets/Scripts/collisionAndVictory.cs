﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionAndVictory : MonoBehaviour



{
    
    private bool obj1Collected, obj2Collected, obj3Collected = false;
    public Text obj1Text, obj2Text, obj3Text;
    public GameObject exit;
    public Text exitSign;
    public Text mainText;
    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "Get your cases on the trolley so you can go home";
        exit.SetActive(false);
        exitSign.text = "_";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            obj1Collected = true;
            obj2Collected = true;
            obj3Collected = true;
            Debug.Log("Player Can Leave");
        }
       
        if (obj1Collected == true && obj2Collected == true && obj3Collected == true)
        {
            Debug.Log("nestyboi");
            mainText.text = "You Found Them! Now Get the Hell Outta There!";
            exit.SetActive(true);
            //exitSign.text = "FREEDOM";
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obj1Tag")
        {
            Destroy(GameObject.FindWithTag("obj1Tag"));
            Debug.Log("OBJ1 collision");
            obj1Text.color = Color.green;
            obj1Collected = true;
        }
        if (collision.gameObject.tag == "obj2Tag")
        {
            Destroy(GameObject.FindWithTag("obj2Tag"));
            Debug.Log("OBJ2 collision");
            obj2Text.color = Color.green;
            obj2Collected = true;

        }
        if (collision.gameObject.tag == "obj3Tag")
        {
            Destroy(GameObject.FindWithTag("obj3Tag"));
            Debug.Log("OBJ3 collision");
            obj3Text.color = Color.green;
            obj3Collected = true;
        }
    }*/
}
