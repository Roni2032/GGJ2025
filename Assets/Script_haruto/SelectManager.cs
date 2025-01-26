using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    int selectNumber = 0;
    [SerializeField]
    List<GameObject> selectList;
    [SerializeField]
    List<GameObject> selectSign;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            selectList[selectNumber].GetComponent<SelectBubble>().Next();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            selectNumber--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            selectNumber++;
        }
        selectNumber = Mathf.Max(0, selectNumber);
        selectNumber = Mathf.Min(selectList.Count - 1, selectNumber);
        
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
