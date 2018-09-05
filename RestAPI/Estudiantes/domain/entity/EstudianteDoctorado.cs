namespace Estudiantes.Domain.Entity{
    public class EstudianteDoctorado: Estudiante{
        public override decimal calculateScholarship(){
            this.Scholarship=100;
            return this.Scholarship;
        }
    }
}