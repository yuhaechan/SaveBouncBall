using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    private static GameSceneManager instance = null;

    public static GameSceneManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(GameSceneManager)) as GameSceneManager; 
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

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static implicit operator GameSceneManager(GameManager v)
    {
        throw new NotImplementedException();
    }
}
