using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Ŭ����(class)
//��ü�� ���� ���踦 ���� ����� ���� ��

//class 
//{
//    //�ʵ�(field) : Ŭ���� ���ο��� ������� ����, ��ü�� �Ӽ��� ǥ���ϴ� �뵵�� ���

//    //�޼ҵ�(method) : Ŭ���� ���ο��� ������� �Լ�, ��ü�� ����, ����� ǥ���ϴ� �뵵�� ���
//}

//����Ƽ���� ����� ������ class��
//���忡 ��ġ�� ������Ʈ�� ���� ������ �� ����

[Serializable]
public class Player
{
    public int hp;  //ü��
    public int max_hp;  //�ִ� ü��
    public string name;
    public Sprite image;    //Sprite�� ����Ƽ���� 2D �̹��� ���Ͽ� ���� ����

    public void Dance()
    {
        Debug.Log($"{name}�� ���� �߰� �ֽ��ϴ�.");
    }

    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("ü���� �̹� ���� ���ֽ��ϴ�");
            return;
        }
        hp += 10;
        Debug.Log($"ü���� 10 ȸ���մϴ�! ����ü�� {hp} / {max_hp}");
    }
}
