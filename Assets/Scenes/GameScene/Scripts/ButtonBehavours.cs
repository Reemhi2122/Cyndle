using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavours : MonoBehaviour {

    public GameObject MoneyPopup;

    public void OnClickAddMoney()
    {
        CloseAllWindows();
        MoneyPopup.SetActive(true);
        
    }



    public void CloseAllWindows()
    {

    }
}
