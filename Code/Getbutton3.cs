using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getbutton3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("3"))
            Application.Quit();
    }
}
