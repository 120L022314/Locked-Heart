using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePosition : MonoBehaviour
{
    public LoadSceneEnding other;
    public move other1;
    public move2 other2;
    public Camera cam;

    public GameObject player1;
    public GameObject player2;
    public GameObject reactor;

    private Vector3 position0;
    private Vector3 position1;
    private Vector3 position2;
    private Vector3 position3;

    private int signal;
    private int size;
    private int speed1;
    private int speed2;

    private bool condition2;
    private bool condition3;
    // Start is called before the first frame update
    void Start()
    {
        condition2 = false;
        condition3 = false;

        size = 15;
        cam.orthographicSize = size;

        position0.x = -22.5f;
        position0.y = -24.5f;
        position0.z = 0;

        position1.x = -20;
        position1.y = -25;
        position1.z = -10;

        position2.x = -42.5f;
        position2.y = -38.5f;
        position2.z = 0;

        position3.x = 2.5f;
        position3.y = -11.5f;
        position3.z = 0;

        reactor.transform.position = position0;
        transform.position = position1;
        player1.transform.position = position2;
        player2.transform.position = position3;
    }

    // Update is called once per frame
    void Update()
    {
        signal = other.signal;
        if(signal==2 && !condition2)
        {
            condition2 = true;

            position0.x = 7.5f;
            position0.y = 49.5f;
            position0.z = 0f;

            position1.x = 6;
            position1.y = 49;
            position1.z = -10;

            position2.x = -16.5f;
            position2.y = 62.5f;
            position2.z = 0;

            position3.x = 28.5f;
            position3.y = 35.5f;
            position3.z = 0;

            reactor.transform.position = position0;
            transform.position = position1;
            player1.transform.position = position2;
            player2.transform.position = position3;
        }
        else if(signal==3 && !condition3)
        {
            condition3 = true;
            
            position0.x = 58.5f;
            position0.y = 8.5f;
            position0.z = 0f;

            position1.x = 56;
            position1.y = 8;
            position1.z = -10;

            position2.x = 33.5f;
            position2.y = 21.5f;
            position2.z = 0;

            position3.x = 73.5f;
            position3.y = -6.5f;
            position3.z = 0;

            reactor.transform.position = position0;
            transform.position = position1;
            player1.transform.position = position2;
            player2.transform.position = position3;
        }
        else if(signal>3)
        {
            speed1 = 0;
            speed2 = 0;
            size = 80;
            other1.speed = speed1;
            other2.speed = speed2;
            
            position1.x = 47;
            position1.y = 11.5f;
            position1.z = -10;

            cam.orthographicSize = size;
        }
    }
}
