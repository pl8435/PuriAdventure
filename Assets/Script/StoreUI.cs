using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreUI : MonoBehaviour
{
    public GameObject StoreDown;
    public GameObject StoreUp;
    public GameObject Heart;
    public GameObject Bubble;
    public GameObject Strong;
    public GameObject Pay;
    public GameObject Cancel;
    public GameObject Thanks;

    public void Down2Up()
    {
        StoreDown.SetActive(false);
        Pay.SetActive(false);
        StoreUp.SetActive(true);
        Cancel.SetActive(true);
    }

    public void Up2Down()
    {
        StoreDown.SetActive(true);
        Pay.SetActive(false);
        StoreUp.SetActive(false);
        Cancel.SetActive(false);
    }

    public void Down2Heart()
    {
        StoreDown.SetActive(false);
        Pay.SetActive(true);
        Heart.SetActive(true);
        Cancel.SetActive(true);
    }

    public void Heart2Down()
    {
        StoreDown.SetActive(true);
        Pay.SetActive(false);
        Heart.SetActive(false);
        Cancel.SetActive(false);
    }

    public void Down2Bubble()
    {
        StoreDown.SetActive(false);
        Pay.SetActive(true);
        Bubble.SetActive(true);
        Cancel.SetActive(true);
    }

    public void Bubble2Down()
    {
        StoreDown.SetActive(true);
        Pay.SetActive(false);
        Bubble.SetActive(false);
        Cancel.SetActive(false);
    }

    public void Down2Strong()
    {
        StoreDown.SetActive(false);
        Pay.SetActive(true);
        Strong.SetActive(true);
        Cancel.SetActive(true);
    }

    public void Strong2Down()
    {
        StoreDown.SetActive(true);
        Pay.SetActive(false);
        Strong.SetActive(false);
        Cancel.SetActive(false);
    }

    public void StoreUp2Pay()
    {
        StoreUp.SetActive(false);
        Pay.SetActive(false);
        Heart.SetActive(false);
        Bubble.SetActive(false);
        Strong.SetActive(false);
        Thanks.SetActive(true);
    }

    public void Pay2StoreUp()
    {
        StoreUp.SetActive(true);
        Pay.SetActive(false);
        Thanks.SetActive(false);
    }
}
