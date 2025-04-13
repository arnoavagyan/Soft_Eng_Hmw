/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using hmw.src.DATA.DATA.SQL.Entities;


namespace hmw.src.BUSINESS.BL.Messaging.Services
{
    public interface IMessaging
    {
        public void Publish(Message message);
    }
}
