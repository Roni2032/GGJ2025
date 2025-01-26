using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadManager : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -10.0f)
        {
            Debug.Log("Ž€I");
            SceneManager.LoadScene("FailedResult");
        }
    }
}
