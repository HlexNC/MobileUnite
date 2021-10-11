using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystic_touch : MonoBehaviour
{
    public GameObject touch_marker;

    Vector3 target_vector;

    public Square_green_controller sg_controller;
    
    void Start()
    {
        touch_marker.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touch_pos = Input.mousePosition;

            target_vector = touch_pos - transform.position;

            if (target_vector.magnitude < 100)
            {
                touch_marker.transform.position = touch_pos;
                sg_controller.target_move = target_vector;
            }
        }
        else
        {
            touch_marker.transform.position = transform.position;
            sg_controller.target_move = new Vector3(0, 0, 0);
        }
        Input.GetAxis("Horizontal");
    }
}
