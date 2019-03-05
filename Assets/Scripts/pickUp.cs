using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    public GameObject playerCamera;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
     //GameObject tempParent = GameObject.FindGameObjectWithTag("TempParent").gameObject;
     tempParent = Camera.main.transform.GetChild(0).gameObject;
     //GameObject playerCamera = GameObject.FindGameObjectWithTag("MainCamera").gameObject;
     //heldObj = this.gameObject;
     throwForce = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding == true)

        {
            
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.transform.SetParent(tempParent.transform);
            

            if (Input.GetKeyDown(KeyCode.E))
            {
                isHolding = false;
                this.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce, ForceMode.Impulse);
               
            }
        }

        else
        {
            objectPosition = this.transform.position;
            this.transform.SetParent(null);
            this.GetComponent<Rigidbody>().useGravity = true;
            this.transform.position = objectPosition;
            this.GetComponent<Rigidbody>().isKinematic = false;
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
