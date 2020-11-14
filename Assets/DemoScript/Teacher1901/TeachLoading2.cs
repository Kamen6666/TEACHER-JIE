using UnityEngine;
using System.Collections;

using U3DEventFrame;
using System;

public class TeachLoading2 : UIBase
{
    public override void ProcessEvent(MsgBase msg)
    {
        switch (msg.msgId)
        {

            
            case  (ushort)LoadingEvent.Initial:
            {


            }
            break;

            case  (ushort)LoadingEvent.Loading:
            {

                    Debug.Log(" bundle  comback !!");

                    AssetResponseMsg tmpMsg = (AssetResponseMsg)msg;

                    // Resources.load
                    UnityEngine.Object[]  tmpObj=  tmpMsg.GetBundleRes("Loading", "Loading.prefab");


                    GameObject  tmpGame= GameObject.Instantiate(tmpObj[0])  as  GameObject ;



                    tmpObj = tmpMsg.GetBundleRes("Regist", "Regist.prefab");

                    tmpGame = GameObject.Instantiate(tmpObj[0]) as GameObject;


                }
            break;


            default:
                    break;
        }




    }


    void Awake()
    {


        msgIds = new ushort[] {

             (ushort) LoadingEvent.Initial,
            (ushort)LoadingEvent.Loading
        };

        RegistSelf(this, msgIds);
    }


    private void Start()
    {
        GetResoures();

    }


    private void ReleaseBundle()
    {
        //HunkAssetRes tmpMsg = ObjectPoolManager<HunkAssetRes>.Instance.GetFreeObject();

        //tmpMsg.ChangeReleaseBundleMsg((ushort)AssetEvent.ReleaseBundleAndObject, "scenceName", "bundleName");


        //SendMsg(tmpMsg);

        //ObjectPoolManager<HunkAssetRes>.Instance.ReleaseObject(tmpMsg);

    }

    private void GetResoures()
    {


        //        --- 申请多个bundle 里面多个资源

        //-- bundle 对应的名字   以下是二个bundle 包

        string[] bundle = {
                               "Loading","Regist"
                           };



        string[][] resName = new string[2][];

        //第一bundle 包里的资源名字
        resName[0] = new string[1] { "Loading.prefab"};
        //第二bundle 包里的
        // ------- -----------------------------这里面要加后缀 .prefab   .png----------TestTwo多个情况不用加----------
        resName[1] = new string[1] {  "Regist.prefab" };

         

        bool[][] singles = new bool[2][];

        //第一bundle 包里的资源 是单个资源还是多个资源true 表示单个
        singles[0] = new bool[1] { true };
        //第二bundle 包里的资源 是单个资源还是多个资源true 表示单个
        singles[1] = new bool[1] { true };


        AssetRequesetMsg tmpMsg = ObjectPoolManager<AssetRequesetMsg>.Instance.GetFreeObject();

        tmpMsg.ChangeEventMsg((ushort)AssetEvent.HunkMutiRes, (ushort)LoadingEvent.Loading, "Demo", bundle, resName, singles);


        SendMsg(tmpMsg);

        ObjectPoolManager<AssetRequesetMsg>.Instance.ReleaseObject(tmpMsg);



    }


    private void JumpNextView()
    {

      //  MsgBase  tmpMsg= ObjectPoolManager<MsgBase>.Instance.GetFreeObject();

     //   tmpMsg.ChangeEventId((ushort)PoleEvent.ReadData);

      //  SendMsg(tmpMsg);


       // ObjectPoolManager<MsgBase>.Instance.ReleaseObject(tmpMsg);

    }

}
