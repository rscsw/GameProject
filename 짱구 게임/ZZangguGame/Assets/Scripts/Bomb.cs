using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private bool isTop = false;
    private int speed = 5;

    void Update()
    {
        if (!isTop)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y >= 3)
                isTop = true;
        }
        else
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x < -10)
            Destroy(this.gameObject);
    }
}
