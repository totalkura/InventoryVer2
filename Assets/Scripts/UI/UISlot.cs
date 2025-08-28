using UnityEngine;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    private Sprite icon;
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
                icon = UIManager.Instance.images[i];
        }
    }
}
