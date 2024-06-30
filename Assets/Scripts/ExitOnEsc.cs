using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 初始化时无需操作
    }

    // 用于按钮点击事件的公共方法
    public void OnQuitButtonPressed()
    {
        QuitGame();
    }

    void QuitGame()
    {
        // 输出到控制台，表明要退出游戏
        Debug.Log("Quitting game.");

        // 如果是在Unity编辑器中，停止播放
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // 如果是在编译后的游戏中，关闭应用程序
        Application.Quit();
        #endif
    }
}

