using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour {
    public GameObject[] characterPrefabs;//建立公有数组characterPrefabs
    public UIInput nameInput;//建立私有对象
    private GameObject[] characterGameObjects;//建立私有数组characterGameObjects
    private int selectedIndex = 0;//建立私有类型selectedInde，确认当前选择的是那个角色，索引
    private int length;//建立私有类型length，定义所有角色的个数
	// Use this for initialization
	void Start ()
    {//调用CharacterCreation函数，Awake()是在脚本对象实例化时被调用的，
     //而Start()是在对象的第一帧时被调用的，而且是在Update()之前。
        length = characterPrefabs.Length;
        characterGameObjects = new GameObject[length];
        for (int i = 0; i < length; i++) {
            characterGameObjects[i] = GameObject.Instantiate(characterPrefabs[i], transform.position, transform.rotation) as GameObject;
        }//for循环角色数组，用以选择角色旋转角色
        UpdateCharacterShow();//展现角色
	}
	
	// Update is called once per frame
	void UpdateCharacterShow () {//建立展现角色的方法
        characterGameObjects[selectedIndex].SetActive(true);//展现当前角色
        for (int i = 0; i < length; i++) {
            if (i != selectedIndex) {
                characterGameObjects[i].SetActive(false);//非展现角色不展现
            }
        }
	}
    public void OnNetButtonClick() {//点击下一个按钮实现角色变换，
        selectedIndex++;//角色索引+1，即替换成下一个索引角色
        selectedIndex %= length;//因为游戏中第二个索引是1，第一个是0
        UpdateCharacterShow();//
    }
    public void OnPrevButtonClick() {
        selectedIndex--;
        if (selectedIndex == -1) {
            selectedIndex = length - 1;
        }
        UpdateCharacterShow();//同上，因是向后退所以代码有所变动
    }
    public void OnOkButtonClick() {//调用Gnui文本组件后使用OK按钮
        PlayerPrefs.SetInt("SelectdeCharacterIndex", selectedIndex);//设置由key确认的参数值
        PlayerPrefs.SetString("name", nameInput.value);//
    }
}
