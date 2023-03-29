using System.ComponentModel;
namespace CazhOn.ConstantsEnums.Enums
{
    public class StatusEnums
    {
     
        public enum BatchStatus
        {
            Processing,
            Failed,
            Success,
            
        }

        public enum ProcessStatus
        {
            Completed,
            Error
        }
        public enum RechargeCode
        {
            [Description("SMS")]
            SMS,
            [Description("Local")]
            Local,
            [Description("STD")]
            STD,
            [Description("ISD")]
            ISD,
            [Description("Other")]
            Other,
            [Description("Validity")]
            Validity,
            [Description("2G Data")]
            _2GData,
            [Description("3G Data")]
            _3GData,
            [Description("4G Data")]
            _4GData,
            [Description("Roaming")]
            Roaming,
            [Description("FRC")]
            FRC,
            [Description("Plan")]
            Plan,
            [Description("Top up")]
            Topup,
            [Description("Full Talktime")]
            FullTT
        }

        public enum PaymentStatus
        {
            Approved,
            Rejected,
            Pending,
        }
        public enum RechargeDaddy
        {
            BAL,
            RECH,
            STATUS,
            TRNCMP
        }
        public enum BatchNames
        {
            ËmailProcess,
            TransactionAPI,
            CouponAPI           
        }

        public enum ResultOutcome
        {
            SUCCESS,
            FAILURE,
            Pending,
            Failed,
            Success
        }
        public enum UriType
        {
            REQUEST,
            RESPONSE
        }
        public enum lkuplist
        {
            giftcardcashback
        }

       
    }
}
