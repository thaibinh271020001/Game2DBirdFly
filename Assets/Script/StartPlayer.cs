using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    public bool isStart;
    public GameObject Btn;

    public void jumpWhenClick()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
    
    public void rmBtn()
    {
        if (Btn.activeInHierarchy == false)
        {
            isStart = true;
        }
    }
}
