using System;
using System.Collections.Generic;

namespace WhateverChatService
{
    public class WhateverChatClientManager
    {
        #region Singleton
        private static readonly WhateverChatClientManager Singleton = new WhateverChatClientManager();
       public static WhateverChatClientManager Instance { get { return Singleton; } }
        private WhateverChatClientManager()
        {
          _clientList=new List<WhateverChatClient>(); 
        }
        #endregion

        private List<WhateverChatClient> _clientList;

        public WhateverChatClient AddClient()
        {
            var whateverChatClient = new WhateverChatClient
                {
                    Id = Guid.NewGuid().ToString(),
                    State = WhateverChatClientState.Idle
                };
            _clientList.Add(whateverChatClient);
            return whateverChatClient;
        }
    }

}