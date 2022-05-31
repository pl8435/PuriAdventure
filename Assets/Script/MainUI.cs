using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void Stage()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void Store()
    {
        SceneManager.LoadScene("StoreScene");
    }

    public void Cleanup()
    {
        SceneManager.LoadScene("CleanupScene");
    }

    public void Puzzle()
    {
        SceneManager.LoadScene("PuzzleScene");
    }
}
