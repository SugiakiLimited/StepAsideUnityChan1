using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallCont : MonoBehaviour
{
    // Unityちゃんのオブジェクト
    private GameObject unitychan;
    // Unityちゃんと壁の距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクト   
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんと壁の位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせて壁を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);

    }
    // トリガーモードで消し去る壁に他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {
        // 接触したオブジェクトを破棄    
        Destroy(other.gameObject);
    }

}
