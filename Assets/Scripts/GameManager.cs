using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Character character;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    public void SetData()
    {
        character = new Character("Player001", 10, 20, 100, 15, 1, 1, 10);
    }
}
