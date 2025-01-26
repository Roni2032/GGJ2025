using TMPro;
using UnityEngine;

public class DrawResult : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;
    void Start()
    {
        int minute = Timer.GetMinute();
        int second = Timer.GetSecond();

        timeText.text = "time  " + minute + " : ";
        if(second < 10)
        {
            timeText.text += "0";
        }
        timeText.text += second;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
