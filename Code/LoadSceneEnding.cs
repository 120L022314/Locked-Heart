using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneEnding : MonoBehaviour
{
    

    private int flag1=0;
    private int flag2=0;
    public int signal = 1;


    private void Start()
    {
        signal = 1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player1")
        {
            flag1 = 1;
        }
        if (other.tag == "Player2")
        {
            flag2 = 1;
        }
        if ((flag1 + flag2) == 2)
        {
            flag1 = 0;
            flag2 = 0;
            signal++;
            
        }
    }
}
