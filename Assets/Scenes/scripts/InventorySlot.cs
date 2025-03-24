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
        if(slotItem != null && insptionWindow.activeInHierarchy)
        {   
            inspectionImage.sprite = slotItem.itemSprite;
            inspecionName.text = slotItem.itemName;
            inspectionDescription.text = slotItem.itemDescription;

            insptionWindow.SetActive(true);
        }
    }
}
