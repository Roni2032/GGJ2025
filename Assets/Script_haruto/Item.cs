using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    string itemName;
    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    float offsetY;
    float rad;
    Vector3 originPosition;
    public string GetName()
    {
        return itemName;
    }
    void Start()
    {
        originPosition = transform.position;
        rad = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rad += Mathf.PI * 2.0f * Time.deltaTime * speed;
        if(rad > Mathf.PI * 2.0f)
        {
            rad = 0.0f;
        }
        transform.position = new Vector3(originPosition.x,originPosition.y + Mathf.Sin(rad) * offsetY,originPosition.z);
    }
}
