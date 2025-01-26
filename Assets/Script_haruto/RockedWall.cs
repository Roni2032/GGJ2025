using UnityEngine;

public class RockedWall : MonoBehaviour
{
    bool isUnLocked = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isUnLocked) return;

        if(collision.gameObject.tag == "useItem")
        {
            Player player = collision.gameObject.GetComponentInParent<Player>();
            if (player != null)
            {
                if (player.FindItem("key"))
                {
                    player.useItem("key");
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}
