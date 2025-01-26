using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float time = 75.0f;
    void Start()
    {
        time = 0.0f;
    }

    public static int GetMinute()
    {
       return (int) (time / 60);
    }
    public static int GetSecond()
    {
        return (int) (time % 60);
    }
    void Update()
    {
        time += Time.deltaTime;
    }
}
