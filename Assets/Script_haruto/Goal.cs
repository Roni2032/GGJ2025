using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool isArrivedPlayer = false;

    bool GetArrivePlayer()
    {
        return isArrivedPlayer;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeClearResult()
    {
        SceneManager.LoadScene("ClearResult");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isArrivedPlayer = true;
            ChangeClearResult();
        }
    }
}
