using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Xlsx ���ø� Ȱ��ȭ ��ų�� ��ȭ�� �ڵ� �����մϴ�. �⺻���� �����ֽ��ϴ�.");
        Debug.Log("�߸� �� �����Ͱ� �ִٸ� �� ��Ʈ�� �Ľ����� �ʽ��ϴ�.");
        Debug.Log("������ Log�� Ȯ�����ּ���.");
        Debug.Log("Data �ε尰�� ��� �׻� Awake���� ���� ���õ˴ϴ�.");
        Debug.Log("�������� Xlsx ���� ��� �Ľ��� �����մϴ�.");
        Debug.Log(ChessSoul_Info.ChessSoul[0].TimeA);
        Debug.Log(ChessSoul_Info2.ChessSoul[0].TimeA);
    }
}
