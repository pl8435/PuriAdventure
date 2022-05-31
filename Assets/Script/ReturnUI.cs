using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnUI : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("MainScene");
    }
}
