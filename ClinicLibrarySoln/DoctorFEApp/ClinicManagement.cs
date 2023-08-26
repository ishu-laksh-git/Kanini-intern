using DoctorBLLayer;
using DoctorDALLibrary;
using DoctorModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFEApp
{
    public class ClinicManagement
    {
        DoctorRepository doctorRepository;
        IManageDoctor manageDoctor;
        public ClinicManagement()
        {
            doctorRepository = new DoctorRepository();
            InitializeClinic();
            manageDoctor = new ManageDoctor(doctorRepository);
        }
        private void InitializeClinic()
        {
            int choice = 0;
            do
            {
                Doctor doctor = new Doctor();
                try
                {
                    doctor.TakeDoctorDetails();
                    bool result;
                    doctorRepository.Add(doctor, out result);
                    if (result)
                        Console.WriteLine("Doctor Added successfully");
                    else
                    {
                        Console.WriteLine("Don't have space to add a 					doctor ");
                        break;
                    }
                }
                catch (MinusValueNotAcceptedException ms)
                {
                    Console.WriteLine(ms.Message);
                    Debug.WriteLine(ms.Message);
                }
                catch (MinusValueAndZeroNotAcceptedException ms)
                {
                    Console.WriteLine(ms.Message);
                    Debug.WriteLine(ms.Message);
                }
                catch (EmptyStringException ms)
                {
                    Console.WriteLine(ms.Message);
                    Debug.WriteLine(ms.Message);
                }
                catch (NotAnIntegerException ms)
                {
                    Console.WriteLine(ms.Message);
                    Debug.WriteLine(ms.Message);
                }
                catch (InputRangeException ms)
                {
                    Console.WriteLine(ms.Message);
                    Debug.WriteLine(ms.Message);
                }

                Console.WriteLine("Do you want to add another Doctor");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid entry please try again");
                }
            } while (choice != 0);
        }

        void PrintServices()
        {
            Console.WriteLine("Welcome to the Clinic of Healers");
            Console.WriteLine("1. View available doctors");
            Console.WriteLine("2. Book Oppointment");
            Console.WriteLine("3. Cancel Oppointment");
            Console.WriteLine("0. Exit");
        }
        public void InteractWithClinic()
        {
            int choice = 0;
            do
            {
                PrintServices();
                Console.WriteLine("Select a service");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye bye...Get well soon!!!");
                        break;
                    case 1:
                        ShowDoctors();
                        break;
                    case 2:
                        BookOppointments();
                        break;
                    case 3:
                        CancelOppointments();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid service");
                        break;
                }

            } while (choice != 0);
        }



        private void ShowDoctors()
        {
            var doctors = manageDoctor.GetDoctors();
            if (doctors != null)
            {
                for (int i = 0; i < doctors.Length; i++)
                {
                    Console.WriteLine(doctors[i]);
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("Sorry for the inconvinience...doctors 			are busy");
            }
        }
        private void BookOppointments()
        {
            int id;
            Console.WriteLine("Enter the doctor id to book oppointment");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry please try again");
            }
            bool status;
            var doctor = manageDoctor.BookOppointment(id, out status);
            if (status)
            {
                Console.WriteLine("Successfully got oppintment");
                Console.WriteLine("The doctor you choose to consult is:");
                Console.WriteLine(doctor);

            }
            else
            {
                Console.WriteLine("doctor not available to book 					oppointment");
            }
        }
        private void CancelOppointments()
        {
            int id;
            Console.WriteLine("Enter doctor id to cancel your 						oppointment");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry please try again");
            }
            bool status;
            var doctor = manageDoctor.CancelOppointment(id, out status);
            if (status)
            {
                Console.WriteLine("successfully canceled oppointment 				with");
                Console.WriteLine(doctor);
            }
            else
            {
                Console.WriteLine("You don't have any oppointment to 					cancel");
            }
        }

    }
}