using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    private Image icon;
    [SerializeField]
    private GameObject equip;

    private Item slotItem;

    public void Start()
    {
        equip.SetActive(false);
    }

    public void SetItem(Item item)
    {
        slotItem = item;
        RefreshUI(item.itemName);
    }

    public void RefreshUI(string itemname)
    {
        for (int i = 0; i < UIManager.Instance.images.Length; i++)
        {
            if (UIManager.Instance.images[i].name == itemname)
                icon.sprite = UIManager.Instance.images[i];
        }
    }

    public void EquipItem()
    {
        ItemEquipCheck();
        GameManager.instance.character.EquipItem(slotItem, equip);
    }

    public void ItemEquipCheck()
    {
        if (name == slotItem.itemName)
            equip.SetActive(true);
        else equip.SetActive(false);
    }
}
