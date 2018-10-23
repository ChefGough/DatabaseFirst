using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }

    [MetadataType(typeof(EnrollmentMetaData))]
    public partial class Enrollment
    {

    }
}