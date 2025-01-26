using UnityEngine;

public class Bubble : MonoBehaviour
{
    Animator animator;
    bool isBurst = false;

    public void Burst()
    {
        isBurst = true;
        this.gameObject.SetActive(false);
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
                this.gameObject.SetActive(false);

            }
        }
    }
}
