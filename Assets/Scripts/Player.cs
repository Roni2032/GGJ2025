using System;
using Unity.Mathematics.Geometry;
using UnityEngine;
using Math = System.Math;

public class Player:MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody2D rigidbody2D;
    private float inputHorizontal;
    private int itemCount = 0;
    private const float kGravity = 9.8f;

    private void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * inputHorizontal * playerSpeed);
        rigidbody2D.AddForce(Vector2.up * rigidbody2D.mass * kGravity / (itemCount + 1.05f));
    }
}
