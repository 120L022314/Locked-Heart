using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject other;
    Vector3 distance,position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        position.x = other.transform.position.x;
        position.y = other.transform.position.y;
        distance = other.transform.position - position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = other.transform.position - distance;
    }
}
