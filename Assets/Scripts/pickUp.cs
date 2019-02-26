using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    

    private Vector3 objectPosition;
    private float distance;

    public float throwForce;
    public bool canHold;
    public bool isHolding = false;
    public GameObject heldObj;
    public GameObject tempParent;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding == true)
        {
            heldObj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            heldObj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            heldObj.transform.SetParent(tempParent.transform);

            if (Input.GetKeyDown(KeyCode.E))
            {
                //throw script
            }
        }

        else
        {
            objectPosition = heldObj.transform.position;
            heldObj.transform.SetParent(null);
            heldObj.GetComponent<Rigidbody>().useGravity = true;
            heldObj.transform.position = objectPosition;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        heldObj.GetComponent<Rigidbody>().useGravity = false;
        heldObj.GetComponent<Rigidbody>().detectCollisions = true;
    }

    void OnMouseUp()
    {
        isHolding = false;
    }
}
