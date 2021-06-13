using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyentity : MonoBehaviour
{
    public int Score = 1;
    //public GameObject Enemyplane;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        

        //GameObject Enemyplane = myPrefab;

        if (other.gameObject.tag == "Enimy")//检查碰撞的物体是不是敌机
        {
            Debug.Log("zhuangshangle");
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            UIScore.Instance.totalscore += Score;
            UIScore.Instance.Updatetotalscore();
        }

        
    }
}
