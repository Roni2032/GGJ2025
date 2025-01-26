using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    int selectNumber = 0;
    [SerializeField]
    List<GameObject> selectList;
    [SerializeField]
    List<GameObject> selectSign;

    private float lastHorizontal = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            selectList[selectNumber].GetComponent<SelectBubble>().Next();
        }
        if (horizontal < 0 && lastHorizontal == 0)
        {
            selectNumber--;
        }
        if (horizontal > 0 && lastHorizontal == 0)
        {
            selectNumber++;
        }
        
        selectNumber = Mathf.Max(0, selectNumber);
        selectNumber = Mathf.Min(selectList.Count - 1, selectNumber);
        lastHorizontal = horizontal;
        
        for (int i = 0; i < selectList.Count; i++)
        {
            if (i == selectNumber)
            {
                selectList[i].GetComponent<SelectBubble>().Select();
            }
            else
            {
                selectList[i].GetComponent<SelectBubble>().UnSelect();
            }
        }
        for (int i = 0; i < selectSign.Count; i++)
        {
            if (i == selectNumber)
            {
                selectSign[i].SetActive(true);
            }
            else
            {
                selectSign[i].SetActive(false);
            }
        }
    }
}
