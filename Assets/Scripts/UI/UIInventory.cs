using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private UISlot slotPrefab;
    [SerializeField]
    private Transform inventorySlotTransform;

    private List<UISlot> slotList = new List<UISlot>();

    public void Start()
    {
        InitInventory();
    }

    public void InitInventory()
    {
        if (slotList.Count > 0)
        {
            for (int i = 0; i < slotList.Count; i++)
            {
                UISlot slot = Instantiate(slotPrefab, inventorySlotTransform);
                slotList.Add(slot);
            }
        }
    }
}
