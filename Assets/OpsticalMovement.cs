using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpsticalMovement : MonoBehaviour
{
    public float speed = 0.01f;
    public float range = 3f;
    private float startX;
    private int direction = 1;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        transform.position += new Vector3(speed * direction, 0, 0);

        if (Mathf.Abs(transform.position.x - startX) >= range)
        {
            direction *= -1;
        }
    }
}