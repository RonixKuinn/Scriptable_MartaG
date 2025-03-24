using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;
    public GameObject insptionWindow;

    public Image inspectionImage;
    public Text inspecionName;
    public Text inspectionDescription;

    public Button cloesButton;
    public Button deleteButton;

    void Start()
    {
        Button thisButton = GetComponentInChildren<Button>();
        thisButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null && !insptionWindow.activeInHierarchy)
        {   
            deleteButton.onClick.AddListener(RemoveItem);
            cloesButton.onClick.AddListener(CloseWindow);
            
            inspectionImage.sprite = slotItem.itemSprite;
            inspecionName.text = slotItem.itemName;
            inspectionDescription.text = slotItem.itemDescription;

            insptionWindow.SetActive(true);
        }
    }

    void RemoveItem()
    {
        if(InventoryManager.instance.weapons[slotNumber] != null)
        {
            InventoryManager.instance.weapons[slotNumber] = null;
            InventoryManager.instance.weaponsNames[slotNumber].text = "Empty";
            InventoryManager.instance.weaponsSprites[slotNumber].sprite = null;
        }

        CloseWindow();
    }

    void CloseWindow()
    {
        deleteButton.onClick.RemoveListener(RemoveItem);
        insptionWindow.SetActive(false);
    }
}
