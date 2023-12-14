using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    [SerializeField] Button btn_GameStart;

    private void Start()
    {
        StartScene_Init();
    }

    void StartScene_Init()
    {
        StartScene_Btn_Init();
    }

    void StartScene_Btn_Init()
    {
        btn_GameStart.onClick.RemoveAllListeners();

        btn_GameStart.onClick.AddListener(GameStart);
    }

    void GameStart()
    {
        GameManager.Instance.gamePlay = true;
        GameManager.Instance.stageNum = 0;
        GameSceneManager.Instance.ChangeScene("GameStage0");
    }
}
