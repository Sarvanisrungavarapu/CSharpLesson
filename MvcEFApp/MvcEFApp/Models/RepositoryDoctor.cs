using Microsoft.EntityFrameworkCore;
using MvcEFApp.Migrations;

namespace MvcEFApp.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctor()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var Doctor = ctx.Doctors.Find(id);
            return Doctor;
        }
        public static void AddNewdoctor(Doctor doctor)
        {
            HospitalDbContext ctx=new HospitalDbContext();
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
        public static void ModifyDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(doctor).State = EntityState.Modified;
        ctx.SaveChanges();
        }
        public static void RemoveDoctor(int id)
        {
            HospitalDbContext ctx= new HospitalDbContext();
            Doctor doctor = ctx.Doctors.Find(id);
            ctx.Doctors.Remove(doctor);
            ctx.SaveChanges();
        }
    }
}