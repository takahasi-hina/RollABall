using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        ForeachLoop();
        //WhileLoop();
    }

    private void ForeachLoop()
    {
        throw new NotImplementedException();
    }

    /* while(条件): 条件がtrueである場合、処理を繰り返す
*/


    // Update is called once per frame
    void Update() {
        Debug.Log("whileループで1~100まで数えます");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("whileループを終了します");
    }


}     
    

