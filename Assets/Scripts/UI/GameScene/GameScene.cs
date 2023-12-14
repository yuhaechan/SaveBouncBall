using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScene : MonoBehaviour
{
    [SerializeField] Button btn_Restart;

    private void Start()
    {
        Debug.Log(SceneManager.GetActiveScene());
        GameScene_Init();
    }

    void GameScene_Init()
    {
        GameScene_Btn_Init();
    }

    void GameScene_Btn_Init()
    {
        btn_Restart.onClick.RemoveAllListeners();

        btn_Restart.onClick.AddListener(StageRestart);
    }

    void StageRestart()
    {
        GameManager.Instance.SetStage();
    }




}
