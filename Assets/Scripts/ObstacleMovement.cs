using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float xSpeed;

    void Update()
    {
        transform.Translate(new Vector3(-xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
