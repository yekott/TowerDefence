using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Money_UI : MonoBehaviour
{
    public Text moneyText;

    void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }
}
