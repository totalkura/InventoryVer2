using System.Collections.Generic;
using static UnityEditor.Progress;

public class Character 
{
    public string userName { get; private set; }
    public int userAtt {  get; private set; }
    public int userDef { get; private set; }
    public int userHP { get; private set; }
    public int userCri { get; private set; }
    public int userLevel { get; private set; }
    public int userMaxExp { get; private set; }
    public int userNowExp { get; private set; }
    
    private Item userEquipItem;

    public List<Item> items = new List<Item>();

    public Character (string username, int useratt, int userdef, int userhp, int usercri, int userlevel, int usermaxexp, int usernowexp)
    {
        userName = username;
        userAtt = useratt;
        userDef = userdef;
        userHP = userhp;
        userCri = usercri;
        userLevel = userlevel;
        userMaxExp = usermaxexp;
        userNowExp = usernowexp;
        userEquipItem = null;
    }

    public void Additem(Item item)
    {
        items.Add(item);
    }

    public void EquipItem(Item item)
    {
        if (userEquipItem != null)
        {
            UnEquipItem();
        }

        userEquipItem = item;

        userAtt += item.itemAtt;
        userDef += item.itemDef;
        userHP += item.itemHP;
        userCri += item.itemCri;
    }

    public void UnEquipItem()
    {
        userEquipItem = null;

        userAtt -= userEquipItem.itemAtt;
        userDef -= userEquipItem.itemDef;
        userHP -= userEquipItem.itemHP;
        userCri -= userEquipItem.itemCri;
    }
}
