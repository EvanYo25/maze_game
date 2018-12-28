using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; //Button
using UnityEngine.SceneManagement; //SceneManager
using UnityEngine;

public class GoToSceneOnClick : MonoBehaviour {

    public int sceneIndex; //要載入的Scene

    void Start()
    {
        //為按鈕加入On Click事件
        GetComponent<Button>().onClick.AddListener(() => {
            ClickEvent();
        });
    }

    void ClickEvent()
    {
        //切換Scene
        SceneManager.LoadScene(sceneIndex);
		GameData.Coins = 0;
    }
}
