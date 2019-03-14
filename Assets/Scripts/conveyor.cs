using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor : MonoBehaviour
{

    public GameObject belt;

    public Transform endpoint;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        //PUT IN A LINE OF CODE MEANING IF YOUR HOLDING IT IT WON'T MOVE BROSEPH
        //other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed*Time.deltaTime);
        if (other.GetComponent<pickUp>().isHolding != true)
        {
            other.transform.Translate(endpoint.transform.forward * speed * Time.deltaTime, Space.World);
            //CAN WE MAKE IT A FORCE NOT A TRASNFORM??
        }
    }
    
}
