using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal_L : MonoBehaviour
{
    static public int score_l;
    public TextMeshProUGUI scoreText_l;
    
    private void Awake()
    {
        scoreText_l = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        scoreText_l.text = "Score: " + score_l;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            score_l++;
            Debug.Log(score_l);
        }
    }
}
