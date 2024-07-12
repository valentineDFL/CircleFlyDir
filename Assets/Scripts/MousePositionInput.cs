using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePositionInput : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = $"Mouse Position: {PlayerPrefs.GetString("position")}";
    }

    private void OnDisable()
    {
        PlayerPrefs.DeleteAll();
    }
}
