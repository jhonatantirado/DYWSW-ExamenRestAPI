namespace Estudiantes.Domain.Entity{
    public class EstudianteMaestria: Estudiante{
        public override decimal calculateScholarship(){
            this.Scholarship=50;
            return this.Scholarship;
        }
    }
}