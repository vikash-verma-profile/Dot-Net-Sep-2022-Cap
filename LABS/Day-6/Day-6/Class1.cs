using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Solution of problem Given
    /// </summary>
    class DoctorDetails
    {
        int RegistrationNo;
        string DoctorName;
        string City;
        string AreaofSpecialization;
        string ClinicAddress;
        string ClinicTimings;
        string ContactNo;

        public void GetData()
        {
            Console.WriteLine("Please enter doctor registration number");
            var isvalidated=Validate(Console.ReadLine(), "RegistrationNo");
            if (!isvalidated)
            {
                Console.WriteLine("Please enter correct value of RegistrationNo");
            }
        }
        public bool Validate(string FieldType,string Input)
        {
            switch (FieldType)
            {
                case "RegistrationNo":
                    if (Input.Length==7)
                    {
                        if(!int.TryParse(Input,out RegistrationNo))
                        {
                            Console.WriteLine("Input is not valid");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input is not valid");
                        return false;
                    }
                    break;
                default:
                    break;

            }
            return false;
        }
    }
    class Class1
    {
        public static void Main2()
        {
            Console.WriteLine("Please enter doctor details");
            DoctorDetails d = new DoctorDetails();
            d.GetData();
        }
    }
}
