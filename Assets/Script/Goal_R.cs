using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Goal_R : MonoBehaviour
{
    static public int score_r;
    public TextMeshProUGUI scoreText_r;

    private void Awake()
    {
        scoreText_r = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        scoreText_r.text = "Score: " + score_r;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            score_r++;
            Debug.Log(score_r);
        }
    }
}
