using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public ScriptableItem itemInfo;
   private SpriteRenderer spriteRendered;

   void Awake()
   {
    spriteRendered = GetComponent<SpriteRenderer>();
   }

    void Start()
    {
        spriteRendered.sprite = itemInfo.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
