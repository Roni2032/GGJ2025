using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    [SerializeField]
    string sceneName;
    public void Change()
    {
        SceneManager.LoadScene(sceneName);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
