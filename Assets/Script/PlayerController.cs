using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveV = Input.GetAxisRaw("Vertical")* moveSpeed;
        moveH = Input.GetAxisRaw("Horizontal")* moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH*4, moveV*2).normalized * moveSpeed;
    }
}
