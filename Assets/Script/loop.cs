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

    /* while(����): ������true�ł���ꍇ�A�������J��Ԃ�
*/


    // Update is called once per frame
    void Update() {
        Debug.Log("while���[�v��1~100�܂Ő����܂�");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("while���[�v���I�����܂�");
    }


}     
    

