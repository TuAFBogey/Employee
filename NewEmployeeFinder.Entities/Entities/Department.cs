using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace NewEmployeeFinder.Entities.Entities
{
    public class Department
    {
        /// <summary>
        /// Department ilk oluşturulduğunda bir tane 
        /// boş bir employee nesnesi oluşturulacak.
        /// </summary>
        public Department()
        {
            Employees = new Collection<Employee>();
        }
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public bool IsDeleted { get; set; }

        /// <summary>
        /// Her department birden fazla çalışana sahip olabilir.
        /// Bu yüzden burda bir collection tanımlanmıştır.
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
    }
}
// Veritabanı bire çok ilişkiyi public ICollection<Employee> Employees { get; set; } ve
// public virtual Department Department{get;set;} kısımlarından anlayacaktır.

