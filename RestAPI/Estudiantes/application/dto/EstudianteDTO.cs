namespace Estudiantes.Application.Dto
{
    public class EstudianteDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentCode { get; set; }
        public string StudentType { get; set; }
        public decimal Scholarship { get; set; }
        public bool IsActive { get; set; }

    }

}
