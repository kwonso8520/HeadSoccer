using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField][Range(1, 2)] private int playerNumber = 1;

    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;

    private SpriteRenderer spriterenderer;
    private Rigidbody2D rigid;

    private bool isjump;
    private bool inputJumpKey;
    private float horizontal;

    private void Awake()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        InputKey();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    private void InputKey()
    {
        if (playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.A))
                horizontal = -1;
            else if (Input.GetKey(KeyCode.D))
                horizontal = 1;
            else
                horizontal = 0;

            inputJumpKey = Input.GetKeyDown(KeyCode.W) ? true : false;
        }
        if (playerNumber == 2)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                horizontal = -1;
            else if (Input.GetKey(KeyCode.RightArrow))
                horizontal = 1;
            else
                horizontal = 0;

            inputJumpKey = Input.GetKeyDown(KeyCode.UpArrow) ? true : false;
        }
    }

    private void Move()
    {
        if (inputJumpKey && isjump == false)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isjump = true;
        }
        spriterenderer.flipX = horizontal > 0 ? true : false;
        transform.position += Vector3.right * horizontal * Time.fixedDeltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isjump = false;
        }
    }
}
