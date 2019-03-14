using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hellScript : MonoBehaviour
{
    public GameObject evilSpawner1, evilSpawner2, evilSpawner3, evilSpawner4;
    private bool unleashHell;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unleashHell == true)
        {
          evilSpawner1.SetActive(true);
          evilSpawner2.SetActive(true);
          evilSpawner3.SetActive(true);
          evilSpawner4.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            unleashHell = true;
        }
    }
}
