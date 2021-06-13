using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//引入unity的UI编辑库

public class UIScore : MonoBehaviour
{
    public static UIScore Instance;

    public int totalscore;
    public Text scoretext;//define text to be change


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void Updatetotalscore()
    {
        this.scoretext.text = totalscore.ToString();
    }
    
    
    

}
