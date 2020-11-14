using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using U3DEventFrame;



public  class  RegistMsg:MsgBase
{

    public Transform data;


    public float blood;



    public RegistMsg( ushort  msg ,Transform  tmp,float tmpblood)
    {

        this.msgId = msg;

        this.data = tmp;

        this.blood = tmpblood;

    }
}





public class TeachLoading : UIBase
{

    //接受到 你所感兴趣的消息
    public override void ProcessEvent(MsgBase msg)
    {

        switch (msg.msgId)
        {

            case (ushort)LoadingEvent.Initial:

                {
                    Debug.Log("loading initial");
                }

                break;


            case (ushort)LoadingEvent.Loading:

                break;

            default:
                break;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        // 你有多少个电话号码
        msgIds = new ushort[] {
            (ushort) LoadingEvent.Initial,
            (ushort)LoadingEvent.Loading

        };

        RegistSelf(this, msgIds);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.A))
        {

            //  RegistMsg tmpBase = new RegistMsg((ushort)RegistEvent.Regist,transform,50);

            // this.SendMsg(tmpBase);


            MsgBase tmpBase = new MsgBase((ushort)PlayerEvent2.Attack);
            this.SendMsg(tmpBase);

           // Application.streamingAssetsPath

            

        }
        
    }
}
