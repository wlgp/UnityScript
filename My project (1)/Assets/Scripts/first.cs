using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //����Ƽ ������ �ִ� ����� ����մϴ�.

public class first : MonoBehaviour  //MonoBehaviour�� ����Ǿ��ս��ϴ�
                                    //MonoBehaviour�� ����Ƽ���� ����ϴ� ��ɵ��� ��Ƴ��� Ŭ���� �Դϴ�.
                                    //�̰� ����Ǿ����� ������ ����Ƽ�� ������Ʈ�� ������ �� �����ϴ�.
{
    //����Ƽ�� ��Ʈ��Ʈ�� ������ ����Ŭ�� ���� ������ ��ġ�� �ڵ带 �����ϰ�
    //����Ƽ ������ �����ϴ� ������ �۾��� ����

    public int count = 0;  //����Ƽ �������� ������ �����ϰ� ���Դϴ�
    private float value = 2.0f;  //����Ƽ �������� ������ �ʽ��ϴ�.
    // Start is called before the first frame update
    //ù ������ ���۽� ȣ��Ǵ� �Լ�
    void Start()
    {
        Debug.Log("ù �����ӿ��� Start�� �����ϰڽ��ϴ�.");
    }

    // Update is called once per frame
    //�������� ���� ���� �����ؾ��ϴ� ��ġ
    //�ٽ� ���� ���� �ۼ��Ǵ� ��ġ
    // ��� �ݺ��մϴ�.
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
