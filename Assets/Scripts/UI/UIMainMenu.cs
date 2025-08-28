using UnityEngine;

public class UIMainMenu : MonoBehaviour
{

    public void OpenMainMenu()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false) ;
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }
}
