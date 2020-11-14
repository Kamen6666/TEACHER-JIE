using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using U3DEventFrame;


public class TeachRegist : UIBase

{



    //接受到 你所感兴趣的消息
    public override void ProcessEvent(MsgBase msg)
    {

        switch (msg.msgId)
        {

            case (ushort)LoadingEvent.Initial:
                {

                    Debug.Log("Regist Initial");
                }

                break;

            case (ushort)RegistEvent.Regist:
                {
                    Debug.Log("Regist Initial  222");

                    RegistMsg tmp = (RegistMsg)msg;

                    Debug.Log(tmp.data.name);

                    Debug.Log(tmp.blood);
                }

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

            (ushort)RegistEvent.Regist
     

        };

        RegistSelf(this, msgIds);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
