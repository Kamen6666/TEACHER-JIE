--region *.lua
--Date
--此文件由[BabeLua]插件自动生成



--endregion


local   uiEventsBegin =  LManagerID.LUIManager +1  ;


UIDemoLoadingEvents = {


   "Initial",

   "GetResources",


   "MaxValue",


   Initial,

   GetResources ,
   MaxValue


}

ResetTableKeyValue(uiEventsBegin,UIDemoLoadingEvents);



UIDemoRegistEvents = {

    "Initial",

   "GetResources",

     

    "MaxValue",

    Initial,

    GetResources ,

    MaxValue


}

ResetTableKeyValue(UIDemoLoadingEvents.MaxValue,UIDemoRegistEvents);



LRoateSelfEevent = {

    "Initial",

   "GetResources",

     

    "MaxValue",

    Initial,

    GetResources ,

    MaxValue


}

ResetTableKeyValue(UIDemoRegistEvents.MaxValue,LRoateSelfEevent);

