using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float yLimit;

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
}
