using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField]
    float windPower;
    [SerializeField]
    Vector2 windDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
                
    const float kMaxVelocityX = 4.0f;
    const float kMaxVelocityY = 1.5f;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHitWall hit = collision.gameObject.GetComponent<PlayerHitWall>();
            if (hit.GetIsBurst()) return;

            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector3 pos = collision.transform.position;
                float distance = Mathf.Abs(pos.y - transform.position.y);
                float sizeY = GetComponent<BoxCollider2D>().size.y;
                if(rb.linearVelocityY < kMaxVelocityY && rb.linearVelocityX < kMaxVelocityX)
                {
                    rb.AddForce(windDirection * windPower * Time.deltaTime * (1.0f - (distance / sizeY)));
                }
            }
        }
    }
}
