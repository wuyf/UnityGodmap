using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetLocationInfo : MonoBehaviour
{

    public Text text;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartLocation()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        text.text = jo.Call<string>("GetInfo");
    }
}