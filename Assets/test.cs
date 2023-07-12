using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HuaweiAppGallery;
using UnityEngine.HuaweiAppGallery.Listener;
using UnityEngine.HuaweiAppGallery.Model;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class test : MonoBehaviour, ILoginListener,ICheckUpdateListener
{
    public Image Image;
    private bool islogin;
    private void Awake()
    {
        HuaweiGameService.AppInit();
    }

    // Start is called before the first frame update
    void Start()
    {
        HuaweiGameService.Init();
        HuaweiGameService.CheckUpdate(this);
        HuaweiGameService.ShowFloatWindow();
        HuaweiGameService.Login(this);
    }
    public  void OnUpdateInfo(AndroidJavaObject intent)
    {
        if (intent !=null)
        {
            int status = intent.Call<int>("getIntExtra", "status", 0);
            Debug.Log("OnUpdateInfo status: " + status);
            if (status==0)
            {
                return;
            }

            if (status == 7)
            {
                var  apkUpgradeInfo = intent.Call<AndroidJavaObject>("getSerializableExtra", "updatesdk_update_info");
                Debug.Log("start ShowUpdateDialog");
                HuaweiGameService.ShowUpdateDialog(apkUpgradeInfo, false);
            }
        }
    }

    public void OnMarketInstallInfo(AndroidJavaObject intent)
    {
        throw new NotImplementedException();
    }

    public void OnMarketStoreError(int responseCode)
    {
        throw new NotImplementedException();
    }

    public void OnUpdateStoreError(int responseCode)
    {
        throw new NotImplementedException();
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            if (islogin)
            {
                Image.color=Color.green;
            }
            else
            {
                Image.color=Color.red;
            }
        }
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus)
            HuaweiGameService.HideFloatWindow();
    }

    public void OnSuccess(SignInAccountProxy signInAccountProxy)
    {
        Debug.Log("successlogin");
        islogin = true;
    }

    public void OnSignOut()
    {
    }

    public void OnFailure(int code, string message)
    {
        Image.color=Color.red;
    }
}