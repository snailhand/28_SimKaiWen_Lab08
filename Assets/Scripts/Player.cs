using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int score;

    public float speed;
    public float yLimit;
    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3(transform.position.x,
            Mathf.Clamp(transform.position.y, -yLimit, yLimit), transform.position.z);
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }

    public float GetScore()
    {
        return System.Convert.ToSingle(score);
    }
}
