using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilCaseSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject caseBlue, caseRed, casePink, caseGreen;
    public float spawnRate = 0f;

    public float spawnCap;
    private float scBottom, scTop;

    public float spawnReset = 0f;
    public int spawnRandom;

    public float spawnforce;


    // Start is called before the first frame update
    void Start()
    {
        scBottom = 0.1f;
        scTop = 0.2f;
        spawnCap = 0.2f;


    }

    // Update is called once per frame
    void Update()
    { Debug.Log("rnnin");
        bullshitSpawner();
        
    }

    public void bullshitSpawner()
    {
        spawnRate = spawnRate + Time.deltaTime;
        if (spawnCap < spawnRate)
        {
            Debug.Log("1");
            spawnRandom = Random.Range(1, 5);

            switch (spawnRandom)
            {
                
                case 1:
                    Debug.Log("2");
                    GameObject caseRedInstance = Instantiate(caseRed, transform.position, Quaternion.identity);
                    caseRedInstance.GetComponent<Rigidbody>().AddForce(1f, 1f, spawnforce, ForceMode.Impulse);
                    break;

                case 2:
                    GameObject caseBlueInstance = Instantiate(caseBlue, transform.position, Quaternion.identity);
                    caseBlueInstance.GetComponent<Rigidbody>().AddForce(1f, 1f, spawnforce, ForceMode.Impulse);
                    break;

                case 3:
                    GameObject caseGreenInstance = Instantiate(caseGreen, transform.position, Quaternion.identity);
                    caseGreenInstance.GetComponent<Rigidbody>().AddForce(1f, 1f, spawnforce, ForceMode.Impulse);
                    break;

                case 4:
                    GameObject casePinkInstance = Instantiate(casePink, transform.position, Quaternion.identity);
                    casePinkInstance.GetComponent<Rigidbody>().AddForce(1f, 1f, spawnforce, ForceMode.Impulse);
                    break;
                case 5:
                    GameObject casePink2Instance = Instantiate(casePink, transform.position, Quaternion.identity);
                    casePink2Instance.GetComponent<Rigidbody>().AddForce(1f, 1f, spawnforce, ForceMode.Impulse);
                    break;

            }

            spawnCap = Random.Range(scBottom, scTop);
            spawnRate = 0f;

        }
    }

}
