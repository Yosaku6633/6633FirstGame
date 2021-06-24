using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCreater : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject respawn1;
    public GameObject respawn2;
    public GameObject respawn3;
    public GameObject destroyInfo;
    public GameObject[] respawns;
    //How many entitise there should be 
    //public int allEntity = 3;
    public float refreshNum;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, respawn1.transform.position, respawn1.transform.rotation);
        Instantiate(myPrefab, respawn2.transform.position, respawn2.transform.rotation);
        Instantiate(myPrefab, respawn3.transform.position, respawn3.transform.rotation);
        Destroyentity Destroy = destroyInfo.GetComponent<Destroyentity>();
        
         
        



    }
     // Update is called once per frame
    void Update()
    {
        Destroyentity Destroy = destroyInfo.GetComponent<Destroyentity>();
        Debug.Log("Destroyed = " + Destroy.allEntity);
        //if (Destroy.allEntity == 3)
            //{
            //Debug.Log("created~~~");
            //Instantiate(myPrefab, respawn1.transform.position, respawn1.transform.rotation);
            //Instantiate(myPrefab, respawn2.transform.position, respawn2.transform.rotation);
            //Instantiate(myPrefab, respawn3.transform.position, respawn3.transform.rotation);
            //Destroy.allEntity = 0;
            //}
    }
}
