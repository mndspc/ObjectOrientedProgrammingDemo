using System;


namespace OOPDemo
{
    class NokiaLumia:MobilePhone,IWifi
    {
        #region Explicite Implementation
            //string IWifi.StartWifi()
            //{
            //    return "Starting Wifi Service";
            //}
            //string IWifi.StopWifi()
            //{
            //    return "Stopping Wifi Service";
            //}
            //string IWifi.TrubleShoot()
            //{
            //    throw new NotImplementedException();
            //}
        #endregion

        #region Implicite Implementation
          public string StartWifi()
            {
                return "Starting Wifi Service";
            }
          public string StopWifi()
            {
                return "Stopping Wifi Service";
            }
          public string TrubleShoot()
            {
            throw new NotImplementedException();
            }
        #endregion
        public string PushMessage()
        {
            return "Pushing Message";
        }
    }
}
