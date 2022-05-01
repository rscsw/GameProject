using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Text tutText;
    public GameObject jennyImg;
    
    int num;

    void Start()
    {
        tutText.text = "";
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            num++;
        }

        switch(num)
        {
            case 0:
                tutText.text = "게임 방법에 대해 알려줄게.";
                break;
            case 1:
                jennyImg.SetActive(false);
                tutText.text = "스킬 카드를 적에게 드래그하면 스킬이 사용돼.";
                break;
            case 2:
                tutText.text = "카드가 적과 만나는 즉시 스킬이 발동되니 주의하도록 해.";
                break;
            case 3:
                tutText.text = "전투 중에 캐릭터나 적에게 커서를 올리면 현재 상태를 볼 수 있어.";
                break;
            case 4:
                tutText.text = "적을 모두 쓰러뜨리면 승리, 적이 모두 쓰러지기 전에 캐릭터가 모두 사망하면 패배야.";
                break;
            case 5:
                tutText.text = "행운을 빌어.";
                break;
            case 6:
                SceneManager.LoadScene(3);
                break;
        }
    }
}
