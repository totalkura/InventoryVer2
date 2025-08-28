
public class Item
{
    public string itemName { get; private set; }
    public int itemAtt { get; private set; }
    public int itemDef { get; private set; }
    public int itemHP { get; private set; }
    public int itemCri { get; private set; }

    public Item(string itemname, int itematt, int itemdef, int itemhp, int itemcri)
    {
        itemName = itemname;
        itemAtt = itematt;
        itemDef = itemdef;
        itemHP = itemhp;
        itemCri = itemcri;
    }

}
