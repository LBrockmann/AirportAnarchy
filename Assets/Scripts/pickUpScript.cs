using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{

    public Transform holdGuide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        //GetComponent<Rigidbody>().isKinematic = true; //remove me on fixed
        this.transform.position = holdGuide.position;
        this.transform.parent = GameObject.Find("HoldGuide").transform;
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            
        }
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        //GetComponent<Rigidbody>().isKinematic = false; //remove me also on fix
        GetComponent<BoxCollider>().enabled = true;
    }
}
