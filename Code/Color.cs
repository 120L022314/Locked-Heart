using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private Vector4 color;
    //private byte red=0 ,green=0 ,blue=0 ;
    void Start()
    {
        color = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            //red++;
            //green++;
            //blue++;
            //color.w += Time.deltaTime;
            //color.x += Time.deltaTime;
            //color.y += Time.deltaTime;
            //color.z += Time.deltaTime;
            color.x = 125;
            color.y = 0;
            color.w = 0;
            color.z = 100;
            spriteRenderer.color = color;
        }
    }
}
