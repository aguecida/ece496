//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomMembershipEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class TeamMember
    {
        [Key] public int TeamMembersID { get; set; }
        public Nullable<int> FK_TeamID { get; set; }
        public Nullable<int> FK_UserID { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
