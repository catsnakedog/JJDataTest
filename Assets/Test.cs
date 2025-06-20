using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Xlsx 감시를 활성화 시킬시 변화를 자동 감지합니다. 기본값은 꺼져있습니다.");
        Debug.Log("잘못 된 데이터가 있다면 그 시트는 파싱하지 않습니다.");
        Debug.Log("문제는 Log를 확인해주세요.");
        Debug.Log("Data 로드같은 경우 항상 Awake보다 먼저 세팅됩니다.");
        Debug.Log("여러개의 Xlsx 또한 모두 파싱이 가능합니다.");
        Debug.Log(ChessSoul_Info.ChessSoul[0].TimeA);
        Debug.Log(ChessSoul_Info2.ChessSoul[0].TimeA);
    }
}
