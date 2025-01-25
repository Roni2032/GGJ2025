using Unity.VisualScripting;
using UnityEngine;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isArrivedPlayer = true;
            Debug.Log("go----------ru");
        }
    }
}
