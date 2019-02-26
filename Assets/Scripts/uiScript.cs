using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiScript : MonoBehaviour
{
    public bool obj1Collected;
    public bool obj2Collected;
    public bool obj3Collected;

    public Text obj1Text, obj2Text, obj3Text;
    // Start is called before the first frame update
    void Start()
    {
        obj1Collected = false;
        obj2Collected = false;
        obj3Collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (obj1Collected == true)
        {
            obj1Text.color = Color.green;
        }
        
        if (obj1Collected == true)
        {
            obj2Text.color = Color.green; 
        }
        
        if (obj1Collected == true)
        {
            obj2Text.color = Color.green;
        }
        
    }
}
