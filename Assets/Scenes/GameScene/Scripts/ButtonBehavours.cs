using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonBehavours : MonoBehaviour {

    public GameObject MoneyPopup;

    public void OnClickAddMoney()
    {
        MoneyPopup.SetActive(true);
    }



    public void CloseAllWindows(Button button)
    {
    }
}
