using System;
using HuaweiService;
using HuaweiService.Auth;
using UnityEngine;
using UnityEngine.HuaweiAppGallery;
using UnityEngine.HuaweiAppGallery.Listener;
using UnityEngine.HuaweiAppGallery.Model;
using UnityEngine.UI;

public class test : MonoBehaviour,ILoginListener
{
    private void Awake()
    {
        HuaweiGameService.AppInit();
    }

    public Image image;
    void Start()
    {
        HuaweiGameService.Init();
        HuaweiGameService.Login(this);
    }

    public void OnSuccess(SignInAccountProxy signInAccountProxy)
    {
        image.color=Color.green;
    }

    public void OnSignOut()
    {
    }

    public void OnSuccess()
    {
     
    }

    public void OnFailure(int code, string message)
    {
        image.color=Color.red;
    }
}



