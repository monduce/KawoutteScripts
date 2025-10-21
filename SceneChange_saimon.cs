using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange_saimon : MonoBehaviour
{
    public Slider playerslider;
    public Slider enemyslider;
    public void TitleScene()
    {
        FadeManager.Instance.LoadScene("GameScene", 1.0f);
    }
    
    public void GameScene()
    {
        if (playerslider.value == 0)
        {
            FadeManager.Instance.LoadScene("ResultGameOverScene", 1.0f);
        }
        if (enemyslider.value == 0)
        {
            FadeManager.Instance.LoadScene("ResultScene", 1.0f);
        }
    }
    
    public void ResultScene()
    {
        FadeManager.Instance.LoadScene("TitleScene", 1.0f);
    }
}
