using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.Domain.Service
{
    using Estudiantes.Domain.Entity;
    using Common.Application;

    public class EstudianteDomainService
    {
        public decimal calculateScholarship(Estudiante estudiante) {
            try {
                Notification notification = this.validation(estudiante);
                if (notification.hasErrors())
                {
                    throw new ArgumentException(notification.errorMessage());
                }
                return estudiante.calculateScholarship();
            }
            catch (Exception){
                throw;
            }
        } 
        public Notification validation(Estudiante estudiante){

            Notification notification = new Notification();

            if (estudiante == null){
                notification.addError("The student code doesn't exist");
                return notification;
            }

            notification = estudiante.validateForSave();
            return notification;
        }

    }
}
