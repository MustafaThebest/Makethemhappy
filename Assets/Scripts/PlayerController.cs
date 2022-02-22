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
        transform.position += moveX * Vector3.right * speed;
    }
}
