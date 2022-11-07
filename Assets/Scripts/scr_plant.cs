using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_plant : MonoBehaviour
{
    public float speed;
    private float hSpeed = 0;
    private float vSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //slow down gradually
        Vector3 curPos = transform.position;

        if (Input.GetKeyDown(KeyCode.A))
        {
            hSpeed = -speed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            hSpeed = speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            vSpeed = speed;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            vSpeed = -speed;
        }

        curPos.x += hSpeed;
        curPos.y += vSpeed;
        transform.position = curPos;
    }
}
