using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public GameObject jennyImg, gukhwaImg;
    public Text narText, nameText;

    string jenny = "권제니";
    string gukhwa = "한국화";
    int num;

    void Start()
    {
        nameText.text = "";
        narText.text = "";
        jennyImg.SetActive(false);
        gukhwaImg.SetActive(false);
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
                jennyImg.SetActive(true);
                nameText.text = jenny;
                narText.text = "먹을 게 다 떨어졌어….";
                break;
            case 1:
                jennyImg.SetActive(false);
                gukhwaImg.SetActive(true);
                nameText.text = gukhwa;
                narText.text = "곧 저녁 때인데 아무것도 없단 말이야?";
                break;
            case 2:
                gukhwaImg.SetActive(false);
                jennyImg.SetActive(true);
                nameText.text = jenny;
                narText.text = "더 어두워지기 전에 사냥을 해오는 게 좋겠어.";
                break;
            case 3:
                jennyImg.SetActive(false);
                gukhwaImg.SetActive(true);
                nameText.text = gukhwa;
                narText.text = "좋아.";
                break;
            case 4:
                SceneManager.LoadScene(2);
                break;
        }
    }
}
