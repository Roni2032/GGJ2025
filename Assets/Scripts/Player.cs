using UnityEngine;

public class Player:MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody2D rigidbody2D;
    private float inputHorizontal;
    
    private void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * inputHorizontal * playerSpeed);
    }
}
