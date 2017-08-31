using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonContainer : MonoBehaviour {
    //数据保存，场景之间数据切换传递使用PlayerPrefs
    //2.场景的分类
        //2.1场景开始
        //2.2角色选择界面
        //2.3角色所在游戏中的界面
    // Use this for initialization
    public void OnNewGame() {
        PlayerPrefs.SetInt("DataFromSave", 0);//加载进2.2
        Application.LoadLevel(2);
    }
    public void OnLoadGame() {
        PlayerPrefs.SetInt("DataFromSave", 1);//加载进2.3
    }
}
