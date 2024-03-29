//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedRose.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrimaryTyping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrimaryTyping()
        {
            this.ChargedAttacks = new HashSet<ChargedAttack>();
            this.ElementalTypings = new HashSet<ElementalTyping>();
            this.FastAttacks = new HashSet<FastAttack>();
        }
    
        public int PrimaryTypingId { get; set; }
        public string PrimaryTypingName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChargedAttack> ChargedAttacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementalTyping> ElementalTypings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastAttack> FastAttacks { get; set; }
    }
}
