using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScroller : MonoBehaviour
{
    private float scrollSpeed = -0.1f;
    private float targetOffset;
    Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    void Update()
    {
        targetOffset += Time.deltaTime * scrollSpeed;
        rd.material.mainTextureOffset = new Vector2(targetOffset, 0);
    }
}
