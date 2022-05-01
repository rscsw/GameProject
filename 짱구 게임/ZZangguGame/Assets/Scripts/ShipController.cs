using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private int speed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y > 3)
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        else if (transform.position.y < -3)
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);
    }
}
