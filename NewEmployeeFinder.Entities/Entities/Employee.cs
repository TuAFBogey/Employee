using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Entities.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }

        public int ProjectId { get; set; }

        public int CityId { get; set; }

        public bool IsDeleted { get; set; }

        /// <summary>
        /// Entity Framework department üzerinden değişikleri izleyecek.
        /// Tracking (izleme) yapabilmesi ve hafızasında tutabilmesi için
        /// virtual tanımlanmıştır.
        /// </summary>
        public virtual Department Department{get;set;}

        public virtual Project Project { get; set; }

        public virtual City City { get; set; }
    }
}
