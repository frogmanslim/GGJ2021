using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    [SerializeField]
    public Transform movePoint;
    [SerializeField]
    public LayerMask whatStopsMovement;

    private void Start()
    {
        movePoint.parent = null;
    }

    float t;
    void Update()
    {
        t += Time.deltaTime;
        //transform.position = Easing.EaseVecTwo(Easing.Equation.BackEaseIn, t, transform.position, movePoint.position, 1);
        transform.position = Vector3.Slerp(transform.position, movePoint.position, 0.5f);

        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {

            float xAxe = Input.GetAxisRaw("Horizontal");
            float yAxe = Input.GetAxisRaw("Vertical");

            if (Mathf.Abs(xAxe) == 1f)
            {
                if (!Physics2D.OverlapBox(movePoint.position + new Vector3(xAxe, 0, 0), new Vector2(0.5f,0.5f), whatStopsMovement))
                {
                    movePoint.position += new Vector3(xAxe, 0, 0);
                    t = 0;
                }
            }
            if (Mathf.Abs(yAxe) == 1f)
            {
                if (!Physics2D.OverlapBox(movePoint.position + new Vector3(0, yAxe, 0), new Vector2(0.5f, 0.5f), whatStopsMovement))
                {
                    movePoint.position += new Vector3(0, yAxe, 0);
                    t = 0;
                }
            }
        }
    }
}
