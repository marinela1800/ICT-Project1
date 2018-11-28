﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jsontofields : MonoBehaviour {
    public string URL;
    public Text ID_text;
    // Use this for initialization
    void Start() {
        StartCoroutine(GetDataFromServer());
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator GetDataFromServer()
    {
        WWW www;
        www = new WWW(URL);
        yield return www;

        string json = www.text;

        if(www.isDone)
        {
            Building data = JsonUtility.FromJson<Building>(json);
            ID_text.text = data.id;
        }
    }
}

public class Building {
    public string id;
    public string type;
}
