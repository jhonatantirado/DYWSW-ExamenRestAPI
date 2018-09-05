namespace Estudiantes.Domain.Entity{
    public class EstudiantePregrado: Estudiante{
        public override decimal calculateScholarship(){
            this.Scholarship=10;
            return this.Scholarship;
        }
    }
}