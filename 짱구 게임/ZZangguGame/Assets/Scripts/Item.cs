using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject bomb;
    private int speed = 5;
    private float randomY;

    void Start()
    {
        randomY = Random.Range(-3.0f, 3.0f);
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -10)
            Destroy(this.gameObject);
    }
}
