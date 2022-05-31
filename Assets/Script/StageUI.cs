using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageUI : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    public void Stage12Stage2()
    {
        Stage1.SetActive(false);
        Stage2.SetActive(true);
    }

    public void Stage22Stage1()
    {
        Stage1.SetActive(true);
        Stage2.SetActive(false);
    }

    public void Return()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoStage1()
    {
        SceneManager.LoadScene("Stage1Scene");
    }

    public void GoStage2()
    {
        SceneManager.LoadScene("Stage2Scene");
    }

    public void GoStage3()
    {
        SceneManager.LoadScene("Stage3Scene");
    }

    public void GoStage4()
    {
        SceneManager.LoadScene("Stage4Scene");
    }

    public void GoStage5()
    {
        SceneManager.LoadScene("Stage5Scene");
    }

    public void GoStage6()
    {
        SceneManager.LoadScene("Stage6Scene");
    }
}
