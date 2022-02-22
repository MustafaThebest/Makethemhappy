using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");

        if (moveX > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (moveX < 0)
        {
            transform.rotation = new Quaternion(0, -180, 0, 0);
        }

        transform.position += moveX * Vector3.right * speed;
    }


}
