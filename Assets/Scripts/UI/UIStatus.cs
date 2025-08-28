using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attText;
    public TextMeshProUGUI defText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI criText;

    private void OnEnable()
    {
         attText.text = GameManager.instance.character.userAtt.ToString();
         defText.text = GameManager.instance.character.userDef.ToString();
         hpText.text = GameManager.instance.character.userHP.ToString();
         criText.text = GameManager.instance.character.userCri.ToString();
    }
 
}
