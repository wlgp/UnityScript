using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;

    public Image player_Image;
    public Slider player_hp;
    public Text player_name;

    public GameObject player_UI;

    private void Start()
    {
        player_Image.sprite = player.image;
        player_name.text = player.name;
        player_hp.maxValue = player.max_hp;
        player_hp.value = player.hp;
    }

    private void Update()
    {
        //GetKeyDown : 눌렀을 때(1번)
        //GetKey : 누르는 동안
        //GetKeyup : 누른 걸 땟을때 (1번)
        if(Input.GetKeyDown(KeyCode.I)) //키보드 I 버튼을 눌렀을때
        {
            if(player_UI.activeSelf) //플레이어 UI가 켜져있다면
                player_UI.SetActive(false); //꺼주세요
            else
                player_UI.SetActive(true);  //켜주세요
        }
    }

    //1. 키보드 입력 값에 따라 메소드를 호출
    //2. 유니티의 버튼 등을 활용해 버튼을 눌렀을 때 메소드를 호출합니다.
    public void Action01()
    {
        player.Dance();
    }
    public void Action02()
    {
        player.Heal();
        setValue();
    }

    public void setValue()
    {
        player_hp.value = player.hp;
    }
}
