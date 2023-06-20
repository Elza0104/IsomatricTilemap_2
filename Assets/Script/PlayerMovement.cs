using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerAinme _playerAinmation;
    private Rigidbody2D rb;
    private float moveH, moveV;
    public float moveSpeed = 0.5f;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _playerAinmation = FindObjectOfType<PlayerAinme>();
    }
    void Update()
    {
        
        moveV = Input.GetAxisRaw("Vertical");
        moveH = Input.GetAxisRaw("Horizontal");
    }
    
    private void FixedUpdate()
    {
        Vector2 currentPos = rb.position;
        Vector2 inputVector = new Vector2
            (moveH*0.1f, moveV*0.05f).normalized 
                              * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(currentPos + inputVector);

        _playerAinmation.SetDirection(new Vector2(moveH, moveV));
    }
    
}
