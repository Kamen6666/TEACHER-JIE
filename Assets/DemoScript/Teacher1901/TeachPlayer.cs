using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using U3DEventFrame;


public  enum  PlayerEvent2
{

    Initial =  ManagerID.CharatorManager +1 ,

    Attack,

    MaxValue
}


public class TeachPlayer : CharactorBase

{

    public override void ProcessEvent(MsgBase msg)
    {

        switch (msg.msgId)
        {

            case (ushort)PlayerEvent2.Attack:
                {
                    Debug.Log(" player  attack  !!!");
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
            (ushort) PlayerEvent2.Attack


        };

        RegistSelf(this, msgIds);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
