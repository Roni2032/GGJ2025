using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.Mathematics.Geometry;
using UnityEngine;
using Math = System.Math;

public class Player:MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody2D rigidbody2D;

    SpriteRenderer spriteRenderer;
    PlayerHitWall playerHit;
    private float inputHorizontal;
    private List<Item> items;
    private int itemCount = 0;
    private const float kGravity = 9.8f;

    public bool FindItem(string name)
    {
        foreach (var item in items)
        {
            if (item.name == name)
            {
                return true;
            }
        }
        return false;
    }
    public void useItem(string name)
    {
        foreach (var item in items)
        {
            if (item.name == name)
            {
                items.Remove(item);
            }
        }
    }
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerHit = GetComponent<PlayerHitWall>();
    }
    private void Update()
    {
        if (!playerHit.GetIsBurst())
        {
            inputHorizontal = Input.GetAxis("Horizontal");
        }
        else
        {
            inputHorizontal = 0.0f;
        }
        if(inputHorizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(inputHorizontal > 0) 
        {
            spriteRenderer.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        // 左右移動
        rigidbody2D.AddForce(Vector2.right * inputHorizontal * playerSpeed);
        
        // 上方向に重力未満の力を加えて、力を相殺
        rigidbody2D.AddForce(Vector2.up * rigidbody2D.mass * kGravity / (itemCount + 1.05f));
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            items.Add(other.GetComponent<Item>());
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            itemCount++;
        }
    }
}
