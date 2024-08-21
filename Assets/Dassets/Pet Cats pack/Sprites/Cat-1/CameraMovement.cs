using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    float smoothLevel;

    //ī�޶� �Ѱ� ����
    //[SerializeField] Vector2 minCameraBoundary; // ���� �Ⱦ�
    //[SerializeField] Vector2 maxCameraBoundary; // ���� �Ⱦ�

    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(Player.position.x, Player.position.y, this.transform.position.z);
        //ī�޶� �Ѱ� �ڵ�
        //targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);
        //targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothLevel);
    }
}
