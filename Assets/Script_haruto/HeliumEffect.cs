using UnityEngine;

public class HeliumEffect : ItemEffect
{
    public override void Effect()
    {
        if (!IsMovers()) return;

        base.Effect();
        GameObject myOwner = GetOwner();
        Rigidbody2D rb = myOwner.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * rb.mass * rb.gravityScale / 3.0f);
    }
}
