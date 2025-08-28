using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string userName { get; private set; }
    public int userAtt {  get; private set; }
    public int userDef { get; private set; }
    public int userHP { get; private set; }
    public int userCri { get; private set; }
    public int userLevel { get; private set; }
    public int userNowExp { get; private set; }
    public int userMaxExp { get; private set; }
    public List<Item> userInventory {  get; private set; }

    private Item userEquipItem;
    private GameObject EquipIcon;

    public Character (string username, int useratt, int userdef, int userhp, int usercri, int userlevel, int usernowexp, int usermaxexp, List<Item> userinventory = null)
    {
        userName = username;
        userAtt = useratt;
        userDef = userdef;
        userHP = userhp;
        userCri = usercri;
        userLevel = userlevel;
        userNowExp = usernowexp;
        userMaxExp = usermaxexp;
        userEquipItem = null;
        userInventory = new List<Item>();
    }

    public void Additem(Item item)
    {
        userInventory.Add(item);
    }

    public void EquipItem(Item item,GameObject icon)
    {
        if (userEquipItem != null)
        {
            string nameCheck = userEquipItem.itemName;
            UnEquipItem();
            userInventory.Remove(userEquipItem);
            if (item.itemName == nameCheck) return;
        }

        Additem(item);
        userEquipItem = item;
        EquipIcon = icon;

        EquipIcon.SetActive(true);

        userAtt += item.itemAtt;
        userDef += item.itemDef;
        userHP += item.itemHP;
        userCri += item.itemCri;
    }

    public void UnEquipItem()
    {
        userAtt -= userEquipItem.itemAtt;
        userDef -= userEquipItem.itemDef;
        userHP -= userEquipItem.itemHP;
        userCri -= userEquipItem.itemCri;

        EquipIcon.SetActive(false);

        userEquipItem = null;
    }
}
