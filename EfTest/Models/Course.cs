using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfTest.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //기본 키를 생성하도록 하지 않고 앱에서 기본 키를 지정
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
