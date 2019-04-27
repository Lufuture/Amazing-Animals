using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Text CountText;
    private int Count;

    void Awake()
    {

        Count = 0;
        // CountText = GameObject.Find("UI/Count/Text").GetComponent<Text>();
    }

    public void AutoAdd()
    {
        CountText.text = " " + ++Count;
    }

}
