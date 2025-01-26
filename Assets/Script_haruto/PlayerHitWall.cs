using UnityEngine;

public class PlayerHitWall : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    Bubble bubble;
    [SerializeField]
    float afterBurstCollisionRadius;

    float timer = 0.0f;
    float time = 1.0f;

    bool isBurst = false;

    public bool GetIsBurst()
    {
        return isBurst;
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurst)
        {
            timer += Time.deltaTime;
            if(timer > time)
            {
                GetComponent<Rigidbody2D>().gravityScale = 4.0f;
            }
            else
            {
                GetComponent<Rigidbody2D>().linearVelocityY = 0.0f;
                GetComponent<Rigidbody2D>().linearVelocityX = 0.0f;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBurst) return;
        bubble.Burst();
        animator.SetTrigger("burst");

        isBurst = true;
        GetComponent<CircleCollider2D>().isTrigger = true;
    }
}
