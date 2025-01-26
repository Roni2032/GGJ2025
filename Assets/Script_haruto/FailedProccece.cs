using UnityEngine;

public class FailedProccece : MonoBehaviour
{
    SceneMove sceneMove;
    void Start()
    {
        sceneMove = GetComponent<SceneMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            sceneMove.Change();
        }
    }
}
