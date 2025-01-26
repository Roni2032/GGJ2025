using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    bool isMovers = false;
    GameObject owner;
    [SerializeField]
    float effectTime = 1.0f;

    public void SetOwner(GameObject owner)
    {
        this.owner = owner;
        isMovers = true;
    }
    public bool IsMovers()
    {
        return isMovers;
    }
    public GameObject GetOwner()
    {
        return this.owner;
    }
    public void SetEffectTime(float effectTime)
    {
        this.effectTime = effectTime;
    }
    public virtual void Effect()
    {
        EffectTimer();
    }
    public void EffectTimer()
    {
        if (isMovers)
        {
            effectTime -= Time.deltaTime;
            if (effectTime < 0.0f)
            {
                Player player = owner.GetComponent<Player>();
                if (player != null)
                {
                    player.useItem(GetComponent<Item>().GetName());
                    isMovers = false;
                }
            }
        }
    }
}
