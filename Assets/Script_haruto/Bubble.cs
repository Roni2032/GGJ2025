using UnityEngine;

public class Bubble : MonoBehaviour
{
    Animator animator;
    bool isBurst = false;

    public void Burst()
    {
        isBurst = true;
        Destroy(this.gameObject);
        //animator.SetTrigger("");
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
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
