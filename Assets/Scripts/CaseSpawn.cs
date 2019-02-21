using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseSpawn : MonoBehaviour
{

    public GameObject caseBlue, caseRed, casePink, caseGreen;

    public float spawnRate = 0f;

    public float spawnCap;

    public float spawnReset = 0f;

    public int spawnRandom;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = spawnRate + Time.deltaTime;
        Debug.Log(spawnRate);
        
        if (spawnCap < spawnRate)
        {
            spawnRandom = Random.Range(1, 4);

            switch (spawnRandom)
            {
                case 1:
                    Instantiate(caseRed, transform.position, Quaternion.identity);
                    break;
                
                case 2:
                    Instantiate(caseBlue, transform.position, Quaternion.identity);
                    break;
                
                case 3:
                    Instantiate(caseGreen, transform.position, Quaternion.identity);
                    break;
                
                case 4:
                    Instantiate(casePink, transform.position, Quaternion.identity);
                    break;
                    
            }
            spawnRate = 0f;
           
        }
    }
}
