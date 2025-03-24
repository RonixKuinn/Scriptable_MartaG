using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager instance;
   public ScriptableItem[] weapons;
   public Text[] weaponsNames;
   public Image[] weaponsSprites;

   public InventorySlot[] weaponSlots;

   void Awake()
   {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
   }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i ++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;

                weaponSlots[i].slotItem = item;
                weaponSlots[i].slotNumber = i;

                return;
            }
        }
    }
}
