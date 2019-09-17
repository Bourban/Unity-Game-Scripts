using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float fMovementDir;
    bool bIsTouchingFloor;

    public float fJumpHeight = 50;
    public float fSpeed = 200;
    public float fFeetRadius = 0.5f;

    Rigidbody2D rb;

    public Transform feetPos;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bIsTouchingFloor = Physics2D.OverlapCircle(feetPos.position, fFeetRadius, groundLayer);

        HandleInput();
        HandleFacing();

        rb.velocity = new Vector2(fMovementDir * fSpeed * Time.deltaTime, rb.velocity.y);
    }

    void HandleInput() {

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.A))
        {
            fMovementDir = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            fMovementDir = 1;
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            fMovementDir = 0;
        }


    }

    void Attack()
    {

    }

    void Jump()
    {
        if (bIsTouchingFloor)
        {
            rb.velocity = Vector2.up * fJumpHeight;
        }
    }

    void HandleFacing()
    {
        if (fMovementDir < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (fMovementDir > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

}


