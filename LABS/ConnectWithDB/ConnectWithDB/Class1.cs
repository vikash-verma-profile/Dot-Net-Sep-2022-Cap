using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectWithDB
{
    public interface IAlertDAO
    {
        public void AlertDAO();
    }
    public class AlertDAO : IAlertDAO
    {
        void IAlertDAO.AlertDAO()
        {
            throw new NotImplementedException();
        }
        public AlertDAO(IAlertDAO a)
        {

        }
    }
    class Class
    {
    }
}
