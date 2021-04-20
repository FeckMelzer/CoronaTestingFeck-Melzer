using CoronaTest.Core.Contracts;
using System;
using System.Diagnostics;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace CoronaTest.Core.Services
{
    public class TwilioSmsService : ISmsService
    {
        private readonly string _accountSid;
        private readonly string _authToken;

        public TwilioSmsService(string accountSid, string authToken)
        {
            _accountSid = accountSid;
            _authToken = authToken;
        }

        public bool SendSms(string to, string message)
        {
            try
            {
                // Find your Account Sid and Token at twilio.com/console
                // and set the environment variables. See http://twil.io/secure
                string accountSid = "ACbd3d3ba18aa061c868e1e521c6afda1b";
                string authToken = "741f4d66aae26a81622b799ec8f217d2";

                TwilioClient.Init(accountSid, authToken);

                var sms = MessageResource.Create(
                    body: message,
                    from: new Twilio.Types.PhoneNumber("+16147050123"),
                    to: new Twilio.Types.PhoneNumber(to)
                );
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}
