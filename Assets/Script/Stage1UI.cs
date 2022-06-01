using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1UI : MonoBehaviour
{
    
    public GameObject Text1;
    public GameObject Text2;
    public GameObject butt;
    public GameObject butt2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Text12Text2()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        butt.SetActive(false);
        butt2.SetActive(true);
    }

    public void Text22butten()
    {
        Text2.SetActive(false);
        butt2.SetActive(false);
    }


}
