using System.Runtime.Serialization;
using System.ServiceModel;

namespace WhateverChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWhateverChatService" in both code and config file together.
    [ServiceContract]
    public interface IWhateverChatService
    {
         [OperationContract]
         WhateverChatClient Connect()
         {
             return WhateverChatClientManager.Instance.AddClient();
         }
    }
}
