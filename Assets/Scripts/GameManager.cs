using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Character character;
    public Item item;

    public int maxInventoryCount;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            maxInventoryCount = 24;
            SetData();
        }
        
    }

    public void SetData()
    {
        character = new Character("Player001", 10, 20, 100, 15, 1, 1, 10);
    }
}
