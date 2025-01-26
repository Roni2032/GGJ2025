using System.Collections.Generic;
using UnityEngine;

public class LoadItemEffect : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        List<ItemEffect> effects = new List<ItemEffect>();
        List<Item> items = player.GetItems();

        foreach (Item item in items)
        {
            ItemEffect effect = item.gameObject.GetComponent<ItemEffect>();
            if (effect != null)
            {
                effects.Add(effect);
            }
        }

        foreach (ItemEffect effect in effects)
        {
            effect.Effect();
        }
    }
}
