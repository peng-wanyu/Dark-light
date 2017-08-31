using UnityEngine;
using System.Collections;

public class MovieCamera : MonoBehaviour {

    public float speed = 10;//公有变量模型移动速度

    private float endZ = -20;//-20是考虑到模型体积，鼠标点击坐标

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z < endZ) {//还没有达到目标位置，需要移动
            transform.Translate( Vector3.forward*speed*Time.deltaTime);//每秒移动10直到到达endz
        }
	}
}
