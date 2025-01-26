using TMPro;
using UnityEngine;

public class DrawResult : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;
    void Start()
    {
        timeText.text = "time  " + Timer.GetMinute() + " : " + Timer.GetSecond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
