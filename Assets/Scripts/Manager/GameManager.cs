using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int stageNum = 0;
    public int stageCount = 10;
    public bool gamePlay = false;
    //[SerializeField] TextMeshProUGUI txt_GameeCount;
    //[SerializeField] GameObject waitPopUp;


    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Cannot have two instance of CGame");
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public void NextStage() { ClearStage();  }
        
    void ClearStage()
    {
        stageNum++;
        Debug.Log(stageNum);
        if(stageCount < stageNum)
        {
            GameSceneManager.Instance.ChangeScene("StartScene");
        }
        else
        {
            GameSceneManager.Instance.ChangeScene("GameStage" + GameManager.Instance.stageNum);
        }
    }
    public void SetStage()
    {
        gamePlay = true;
        //StartCoroutine(WaitRoutine());
        GameSceneManager.Instance.ChangeScene("GameStage" + GameManager.Instance.stageNum);
    }
    /*
    IEnumerator WaitRoutine()
    {
        WaitPopUp_Active();
        txt_GameeCount.SetText(GameManager.Instance.stageNum.ToString());
        yield return new WaitForSeconds(2f);
        GameSceneManager.Instance.ChangeScene("GameStage" + GameManager.Instance.stageNum);
        WaitPopUp_DisActive();
    }


    void WaitPopUp_Active()
    {
        waitPopUp.SetActive(true);
    }
    void WaitPopUp_DisActive()
    {
        waitPopUp.SetActive(false);
    }
    */
}
