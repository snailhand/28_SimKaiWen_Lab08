using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float xSpeed;
    public int points;

    private Player playerScript;

    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<Player>();
        
        if(playerScript.GetScore() != 0)
        {
            //Increase speed as score increases
            xSpeed += (1 * playerScript.GetScore()/100);
        }
    }

    void Update()
    {
        transform.Translate(new Vector3(-xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.x < -10)
        {
            playerScript.UpdateScore(points);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneHandler.inst.GameOver();
        }
    }
}
