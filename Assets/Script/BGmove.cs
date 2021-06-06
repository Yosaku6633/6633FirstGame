using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmove : MonoBehaviour
{
    public float Speed;
    public float BGHigh;
    public float BGLow;
    public GameObject bg1;
    public GameObject bg2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bg1 position" + bg1.transform.position.y);
        //Debug.Log("bg2 position");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if (bg1.transform.position.y < BGLow)
        {
            bg1.transform.position = new Vector3(bg1.transform.position.x, BGHigh, bg1.transform.position.z);
           
        }
        if (bg2.transform.position.y < BGLow)
        {
            bg2.transform.position = new Vector3(bg2.transform.position.x, BGHigh, bg2.transform.position.z);
        }
        //Debug.Log("bg2 position");
    }
}
