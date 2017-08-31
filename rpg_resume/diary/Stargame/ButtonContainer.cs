using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonContainer : MonoBehaviour {

    // Use this for initialization
    public void OnNewGame() {
        PlayerPrefs.SetInt("DataFromSave", 0);//确认
        Application.LoadLevel(2);//加载进场景2
    }
    public void OnLoadGame() {
        PlayerPrefs.SetInt("DataFromSave", 1);//加载进2.3
    }
}
