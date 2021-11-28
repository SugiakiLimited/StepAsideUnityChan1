using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallCont : MonoBehaviour
{
    // Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    // Unity�����ƕǂ̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g   
        this.unitychan = GameObject.Find("unitychan");
        //Unity�����ƕǂ̈ʒu�iz���W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹�ĕǂ��ړ�
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);

    }
    // �g���K�[���[�h�ŏ�������ǂɑ��̃I�u�W�F�N�g�ƐڐG�����ꍇ�̏���
    void OnTriggerEnter(Collider other)
    {
        // �ڐG�����I�u�W�F�N�g��j��    
        Destroy(other.gameObject);
    }

}
