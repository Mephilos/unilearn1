using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //플레이어 추적 카메라
    public GameObject player;
    //카메라 위치 설정 변수
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
