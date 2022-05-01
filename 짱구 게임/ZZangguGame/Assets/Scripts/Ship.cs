using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject bomb;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            Instantiate(bomb, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -3), Quaternion.identity);
        }
    }
}
