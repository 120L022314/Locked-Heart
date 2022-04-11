using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    float x;
    float y;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //����������Ϊ����֡����û��̫��ı�Ҫ����ʹ����deltaTime֮��
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 100;

        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        
    }

    private void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x += speed * x * Time.deltaTime;
        position.y += speed * y * Time.deltaTime;
        rigidbody.position = position;
    }
}
