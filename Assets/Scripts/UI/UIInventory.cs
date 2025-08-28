using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private UISlot slotPrefab;
    [SerializeField]
    private Transform inventorySlotTransform;
    [SerializeField]
    private TextMeshProUGUI itemSlotText;

    private List<UISlot> slotList = new List<UISlot>();

    public void Start()
    {
        InitInventory();
        ItemSlotCheck();
        gameObject.SetActive(false);
    }

    private void InitInventory()
    {
        Debug.Log(GameManager.instance.newItem.Count);

        if (GameManager.instance.newItem.Count > 0)
        {
            for (int i = 0; i < GameManager.instance.newItem.Count; i++)
            {
                UISlot slot = Instantiate(slotPrefab, inventorySlotTransform);
                slot.SetItem(GameManager.instance.newItem[i]);
                slotList.Add(slot);
            }
        }
    }

    public void ItemSlotCheck()
    {
        itemSlotText.text = $"{slotList.Count} / {GameManager.instance.maxInventoryCount}";
    }

}
