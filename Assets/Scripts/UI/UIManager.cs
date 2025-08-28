using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;


    [SerializeField]
    private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu => uiMainMenu;

    [SerializeField]
    private UIInventory uiInventory;
    public UIInventory UIInventory => uiInventory;

    [SerializeField]
    private UIStatus uiStatus;
    public UIStatus UIStatus => uiStatus;
   
    public Sprite[] images;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            images = Resources.LoadAll<Sprite>("ItemImage");
        }
    }
}
