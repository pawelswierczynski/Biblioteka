//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ksiazka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ksiazka()
        {
            this.Egzemplarzs = new HashSet<Egzemplarz>();
            this.Autors = new HashSet<Autor>();
        }
    
        public int IdKsiazka { get; set; }
        public Nullable<int> IdWydawnictwo { get; set; }
        public Nullable<int> IdGatunek { get; set; }
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Egzemplarz> Egzemplarzs { get; set; }
        public virtual Gatunek Gatunek { get; set; }
        public virtual Wydawnictwo Wydawnictwo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autors { get; set; }
    }
}