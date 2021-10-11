using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/**
 * @author ： jiangshen
 * @function : 场景跳转
 */

public class Loading : MonoBehaviour
{
  public  Button button;
    void Start()
    {
        // 利用匿名委托跳转场景
       button.onClick.AddListener(delegate() { SceneManager.LoadScene("Game"); });
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
