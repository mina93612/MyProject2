//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAT_RESULTH
    {
        public PAT_RESULTH()
        {
            this.PAT_RESULTD = new HashSet<PAT_RESULTD>();
        }
    
        public decimal PRH_TRX_NUM { get; set; }
        public string PRH_PAT_ID { get; set; }
        public string PRH_BED_NO { get; set; }
        public string PRH_ORDER_DT { get; set; }
        public string PRH_ORDER_NO { get; set; }
    
        public virtual PAT_BASIC PAT_BASIC { get; set; }
        public virtual ICollection<PAT_RESULTD> PAT_RESULTD { get; set; }
    }
}