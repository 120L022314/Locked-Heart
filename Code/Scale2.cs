using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scale2 : MonoBehaviour
{
    public LoadSceneEnding other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int signal = other.signal;
        Vector2 scale = transform.localScale;
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            if (signal < 4)
            {
                scale.x -= 0.1f * Time.deltaTime;
                scale.y -= 0.1f * Time.deltaTime;
                transform.localScale = scale;
            }
        }
        if (scale.x < 1)
            SceneManager.LoadScene("Scene2");
    }
}
