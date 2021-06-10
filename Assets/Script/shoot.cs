using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject myPrefab;
    public float intervalTime = 0.1f;
    private float invokeTime;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        invokeTime = intervalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            invokeTime += Time.deltaTime;
            if (invokeTime - intervalTime > 0)
            {
                GameObject bullet = Instantiate(myPrefab);
                bullet.transform.position = transform.position + new Vector3(0, 1f, 0);
                invokeTime = 0;
            }

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            invokeTime = intervalTime;
        }

    }
}
