using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject ball;
    [SerializeField] private float pushPower = 5;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 upVelocity = (Vector3.up * ((rb.velocity.x + rb.velocity.y) * 0.2f)) + (Vector3.up * 3.5f);
            Vector3 velo = (transform.position - collision.gameObject.transform.position).normalized * pushPower;
            rb.velocity = velo + upVelocity;
        }
    }
}
