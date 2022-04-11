using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 position = transform.position;
        if (Input.GetKey("w"))
        {
            position.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            position.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            position.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            position.x += speed * Time.deltaTime;
        }
        rigidbody.position = position;
    }
}
