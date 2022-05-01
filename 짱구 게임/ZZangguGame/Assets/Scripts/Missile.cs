using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private bool isDown = true;
    private int speed = 5;
    private float randomY;

    void Start()
    {
        randomY = Random.Range(-3.0f, 3.0f);
    }

    void Update()
    {
        if (isDown)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y <= randomY)
                isDown = false;
        }
        else
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -10)
            Destroy(this.gameObject);
    }
}
