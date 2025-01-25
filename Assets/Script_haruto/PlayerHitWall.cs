using UnityEngine;

public class PlayerHitWall : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    Bubble bubble;
    [SerializeField]
    float afterBurstCollisionRadius;

    bool isBurst = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBurst) return;
        bubble.Burst();
        animator.SetTrigger("burst");

        isBurst = true;
        GetComponent<CircleCollider2D>().radius = afterBurstCollisionRadius;
    }
}
