using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrolleyScript : MonoBehaviour
{
    private bool bag1, bag2, bag3;
    private bool bagsFound;
    private bool bagsPacked;
    public Text obj1Text, obj2Text, obj3Text;
    public GameObject hellTrigger;
    

    public GameObject exit;

    public Text mainText;
    // Start is called before the first frame update
    void Start()
    {
        bag1 = false;
        bag2 = false;
        bag3 = false;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (bag1 == true && bag2 == true && bag3 == true)
        {
            mainText.text = "You Found Them! Now Get the Hell Outta There!";
            exit.SetActive(true);
            bagsFound = true;
            bagsPacked = true;
            hellTrigger.SetActive(true);
        }
        else
        {
            bagsPacked = false;
        }

        if (bagsFound == true && bagsPacked == false)
        {
            mainText.text = "You dropped a bag! You can't leave without it!";
            exit.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obj1Tag")
        {
            bag1 = true;
            Debug.Log("1");
            obj1Text.color = Color.green;
        }
        

        if (other.tag == "obj2Tag")
        {
            bag2 = true;
            Debug.Log("2");
            obj2Text.color = Color.green;
        }
        

        if (other.tag == "obj3Tag")
        {
            bag3 = true;
            Debug.Log("3");
            obj3Text.color = Color.green;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "obj1Tag")
        {
            bag1 = false;
            Debug.Log("1Off");
            obj1Text.color = Color.green;
        }
        
        if (other.tag == "obj2Tag")
        {
            bag2 = false;
            Debug.Log("2Off");
            obj2Text.color = Color.black;
        }
        if (other.tag == "obj3Tag")
        {
            bag3 = false;
            Debug.Log("3Off");
            obj3Text.color = Color.black;
        }
    }
}
