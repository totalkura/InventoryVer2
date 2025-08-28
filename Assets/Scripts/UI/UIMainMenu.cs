using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterLevel;
    public TextMeshProUGUI characterExp;

    public Image characterExpBar;

    public void Start()
    {
        characterName.text = GameManager.instance.character.userName;
        characterLevel.text = $"Lv : {GameManager.instance.character.userLevel.ToString()}";
        characterExp.text = $"{GameManager.instance.character.userNowExp} / {GameManager.instance.character.userMaxExp}";

        characterExpBar.fillAmount = (float)GameManager.instance.character.userNowExp / (float)GameManager.instance.character.userMaxExp;
    }

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
