

using U3DEventFrame;


public enum LoadingEvent : ushort
{
    Initial = ManagerID.UIManager + 1,

    Loading,

    Send,

    MaxValue


}


public  enum RegistEvent
{
    Initial =  LoadingEvent.MaxValue+1,


    Regist ,

    MaxValue

}




