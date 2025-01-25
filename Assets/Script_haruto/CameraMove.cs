using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    Vector2 stageEdgeMin;
    [SerializeField]
    Vector2 stageEdgeMax;
    [SerializeField]
    Vector2 cameraHalfSize = new Vector2(8, 5);
    [SerializeField]
    bool isFreezeX;
    [SerializeField]
    bool isFreezeY;
    [SerializeField]
    GameObject player;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (!isFreezeX)
        {
            pos.x = player.transform.position.x;
            if(pos.x + cameraHalfSize.x > stageEdgeMax.x)
            {
                pos.x = stageEdgeMax.x - cameraHalfSize.x;
            }
            if(pos.x - cameraHalfSize.x < stageEdgeMin.x)
            {
                pos.x = stageEdgeMin.x + cameraHalfSize.x;
            }
        }
        if (!isFreezeY)
        {
            pos.y = player.transform.position.y;
            if (pos.y + cameraHalfSize.y > stageEdgeMax.y)
            {
                pos.y = stageEdgeMax.y - cameraHalfSize.y;
            }
            if (pos.y - cameraHalfSize.y < stageEdgeMin.y)
            {
                pos.y = stageEdgeMin.y + cameraHalfSize.y;
            }
        }

        transform.position = pos;
    }
}
