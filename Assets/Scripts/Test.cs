using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U3DEventFrame;

using UnityEngine.UI;



public class Test :  UIBase 
{

    public override void ProcessEvent(MsgBase msg)
    {
        //throw new System.NotImplementedException();

        


        Debug.Log("Test  recv ");

    }


	// Use this for initialization
	void Start () {


        msgIds = new ushort[] 
        {

              (ushort)TestEvent.Recv
        };
		
        RegistSelf(this,msgIds);




        MeshRenderer  tmpRender;

        // tmpRender.sharedMaterial   // 直接修改  mesh  身上的 materail 

      //  tmpRender.material   //  重新拷贝 一个  materail  赋值回去。

        


      //  rect.anchoredPosition
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {

            MsgBase tmpMsg = new MsgBase((ushort)TestEvent.Recv ) ;

            SendMsg(tmpMsg); 
        }
		
	}
}
