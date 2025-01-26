using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectBubble : MonoBehaviour
{
    bool isSelect = false;
    Vector3 originPosition;
    float rad = 0.0f;
    [SerializeField]
    string nextSceneName;
    public void Select()
    {
        isSelect = true;
    }
    public void UnSelect()
    {
        isSelect = false;
    }
    void Start()
    {
        originPosition = transform.position;
    }
    public void Next()
    {
        SceneManager.LoadScene(nextSceneName);
    }
    // Update is called once per frame
    void Update()
    {
        if (isSelect)
        {
            Vector3 pos = transform.position;
            const float PI_2 = Mathf.PI * 2.0f;
            rad += Time.deltaTime * PI_2;
            pos.y = originPosition.y + Mathf.Sin(rad) * 0.1f;

            if (rad > PI_2)
            {
                rad = 0.0f;
            }
            transform.position = pos;
        }
    }
}
