using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.S)){
            MoveDown();
        }
        if (Input.GetKeyDown(KeyCode.A)){
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D)){
            MoveRight();
        }
    }

    void MoveUp()
    {
        transform.localPosition += new Vector3(0,1,0);
    }
    void MoveDown()
    {
        transform.localPosition += new Vector3(0,-1,0);
    }
    void MoveLeft()
    {
        transform.localPosition += new Vector3(-1,0,0);
    }
    void MoveRight()
    {
        transform.localPosition += new Vector3(1,0,0);
    }

}
