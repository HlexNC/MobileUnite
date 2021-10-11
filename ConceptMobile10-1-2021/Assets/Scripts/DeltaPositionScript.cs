using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaPositionScript : MonoBehaviour
{
    public Vector2 position;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - (float)Screen.width) / (float)Screen.width;
                pos.y = (pos.y - (float)Screen.height) / (float)Screen.height;
                position = new Vector3(-pos.x, pos.y);

                // Position the cube.
                transform.position = position;
            }
        }
    }
}
