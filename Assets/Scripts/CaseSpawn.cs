using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class CaseSpawn : MonoBehaviour
{

    public GameObject caseBlue, caseRed, casePink, caseGreen;
    public GameObject obj1, obj2, obj3;
    public float spawnRate = 0f;

    public float spawnCap;
    private float scBottom, scTop;

    public float spawnReset = 0f;
    
    public float Unitime;
    public int spawnRandom;

    private float obj1Spawn;
    private float obj2Spawn;
    private float obj3Spawn;

    private bool obj1Switch;
    private bool obj2Switch;
    private bool obj3Switch;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Unitime = 0f;
        obj1Spawn = Random.Range(10f, 30f);
        obj2Spawn = Random.Range(30f, 150f);
        obj3Spawn = Random.Range(120f, 200f);

        obj1Switch = true;
        obj2Switch = true;
        obj3Switch = true;
        scBottom = 0.2f;
        scTop = 10f;
        spawnCap = 2f;
    }

    // Update is called once per frame
    void Update()
    {
       
        Unitime = Unitime + Time.deltaTime;
        
        objectiveSpawner();
        spawnSpeedUp();
        bullshitSpawner();
    }

    public void bullshitSpawner()
    {
        spawnRate = spawnRate + Time.deltaTime;
        if (spawnCap < spawnRate)
        {
            spawnRandom = Random.Range(1, 5);

            switch (spawnRandom)
            {
                case 1:
                    GameObject caseRedInstance = Instantiate(caseRed, transform.position, Quaternion.identity);
                    caseRedInstance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
                    break;
                
                case 2:
                    GameObject caseBlueInstance =Instantiate(caseBlue, transform.position, Quaternion.identity);
                    caseBlueInstance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
                    break;
                
                case 3:
                    GameObject caseGreenInstance = Instantiate(caseGreen, transform.position, Quaternion.identity);
                    caseGreenInstance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
                    break;
                
                case 4:
                    GameObject casePinkInstance = Instantiate(casePink, transform.position, Quaternion.identity);
                    casePinkInstance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
                    break;
                case 5:
                    GameObject casePink2Instance = Instantiate(casePink, transform.position, Quaternion.identity);
                    casePink2Instance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
                    break;
                    
            }
            spawnCap = Random.Range(scBottom, scTop);
            spawnRate = 0f;
           
        }
    }

    public void objectiveSpawner()
    {
        if (Unitime > obj1Spawn && obj1Switch == true)
        {
            GameObject case1Instance =Instantiate(obj1, transform.position, Quaternion.identity);
            case1Instance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
            obj1Switch = false;
        }
        
        if (Unitime > obj2Spawn && obj2Switch == true)
        {
            GameObject case2Instance = Instantiate(obj2, transform.position, Quaternion.identity);
            case2Instance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
            obj2Switch = false;
        }
        
        if (Unitime > obj3Spawn && obj3Switch == true)
        {
            GameObject case3Instance = Instantiate(obj3, transform.position, Quaternion.identity);
            case3Instance.GetComponent<Rigidbody>().AddForce(-7,1f,1f, ForceMode.Impulse);
            obj3Switch = false;
        }
    }

    public void spawnSpeedUp()
    {
        if (Unitime > 110)
        {
            scTop = 0.2f;
            scBottom = 0.001f;
        }
        
        if(Unitime > 100)
        {
            scTop = 0.5f;
        }
        else if (Unitime > 90)
        {
            scTop = 1f;
        }
        else if (Unitime > 60)
        {
            scTop = 2.5f;
        }
        else if(Unitime > 45)
        {
            scTop = 4f;
        }
        else if(Unitime> 30)
        {
            scTop = 6.5f;
        }
        else
        {
            scTop = 10f;
        }
       
        
    }
}
