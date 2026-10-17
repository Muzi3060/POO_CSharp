using Ex018;

try {
    Aluno aluno = new Aluno("João", 2000, "ADS");
    
    aluno.AddCurso("Marketing");
    aluno.MostrarCursos();
    Console.WriteLine(aluno.SetCurso("Marketing"));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


