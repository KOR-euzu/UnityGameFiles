using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    float smoothLevel;

    //카메라 한계 지정
    //[SerializeField] Vector2 minCameraBoundary; // 아직 안씀
    //[SerializeField] Vector2 maxCameraBoundary; // 아직 안씀

    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(Player.position.x, Player.position.y, this.transform.position.z);
        //카메라 한계 코드
        //targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);
        //targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothLevel);
    }
}
