﻿using UnityEngine;
using UnityEngine.UI;

public class bl_IconItem : MonoBehaviour {

    public Image TargetGrapihc;
    public Sprite DeathIcon = null;
    public Text InfoText = null;
    public float DestroyIn = 5f;
    
    /// <summary>
    /// When player or the target die,desactive,remove,etc..
    /// call this for remove the item UI from Map
    /// for change to other icon and desactive in certain time
    /// or destroy inmediate
    /// </summary>
    /// <param name="inmediate"></param>
    public void DestroyIcon(bool inmediate)
    {
        if (inmediate)
        {
            Destroy(gameObject);
        }
        else
        {
            //Change the sprite to icon death
            TargetGrapihc.sprite = DeathIcon;
            //destroy in 5 seconds
            Destroy(gameObject, DestroyIn);
        }
    }
    /// <summary>
    /// When player or the target die,desactive,remove,etc..
    /// call this for remove the item UI from Map
    /// for change to other icon and desactive in certain time
    /// or destroy inmediate
    /// </summary>
    /// <param name="inmediate"></param>
    /// <param name="death"></param>
    public void DestroyIcon(bool inmediate,Sprite death)
    {
        if (inmediate)
        {
            Destroy(gameObject);
        }
        else
        {
            //Change the sprite to icon death
            TargetGrapihc.sprite = death;
            //destroy in 5 seconds
            Destroy(gameObject, DestroyIn);
        }
    }
    /// <summary>
    /// Get info to desplay
    /// </summary>
    /// <param name="info"></param>
    public void GetInfoItem(string info)
    {
        if (InfoText == null)
            return;

        InfoText.text = info;
    }

    private bool open = false;
    public void InfoItem()
    {
        open = !open;
        Animation a = GetComponent<Animation>();
        if (open)
        {
            a["OpenInfo"].time = 0;
            a["OpenInfo"].speed = 1.0f;
            a.CrossFade("OpenInfo", 0.2f);
        }
        else
        {
            a["OpenInfo"].time = a["OpenInfo"].length;
            a["OpenInfo"].speed = -1.0f;
            a.CrossFade("OpenInfo", 0.2f);
        }
    }
}