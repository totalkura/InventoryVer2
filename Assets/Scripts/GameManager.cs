using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Character character;
    public Item item;

    [SerializeField]
    public List<Item> newItem;

    public int maxInventoryCount;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            SetData();
        }
        
    }

    public void SetData()
    {
        maxInventoryCount = 24;

        newItem = new List<Item>();

        character = new Character("Player001", 10, 20, 100, 15, 1, 1, 10);
        newItem.Add(new Item("sword_01", 30, 0, 0, 5));
        newItem.Add(new Item("spear_01", 40, 0, 0, 0));
        newItem.Add(new Item("armor_01", 0, 20, 50, 0));
        newItem.Add(new Item("belt_01", 0, 5, 100, 0));
        newItem.Add(new Item("ring_01", 5, 0, 0, 15));
        newItem.Add(new Item("necklace_01", 0, 5, 0, 15));

        

    }
}
