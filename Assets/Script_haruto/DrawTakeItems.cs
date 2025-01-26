using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DrawTakeItems : MonoBehaviour
{
    Player player;
    [SerializeField]
    List<GameObject> slots;
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        List<Item> items = player.GetItems();
        for (int i = 0; i < slots.Count; i++)
        {
            SpriteRenderer renderer = slots[i].GetComponent<SpriteRenderer>();
            if (items.Count > i)
            {
                renderer.sprite = items[i].gameObject.GetComponent<SpriteRenderer>().sprite;
            }
            else
            {
                renderer.sprite = null;
            }
        }
        
    }
}
