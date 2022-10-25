Console.WriteLine("1.Cadastrar Curso;\n2.Listar Cursos;\n3.Cadastrar Aluno;\n4.Atribuir Notas;\n5.Estatísticas;\n6.Sair;\n: ");
int opcao = Convert.ToInt16(Console.ReadLine());

List<Cursos> cursos = new List<Cursos>();

List<Alunos> alunos = new List<Alunos>();


if (opcao == 1)
{
    Cursos curso = new Cursos();
    Console.WriteLine("Nome do Curso: ");
    curso.Nome = Console.ReadLine();
    Console.WriteLine("Carga Horaria: ");
    curso.CargaHoraria = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("ID: ");
    curso.ID = Convert.ToInt16(Console.ReadLine());
    cursos.Add(curso);
}
else if (opcao == 2)
{
    for (int i=0; i < cursos.Count; i++)
    {
        Console.WriteLine(cursos[i]);
    }
}
else if (opcao == 3)
{
    Alunos aluno = new Alunos();
    Console.WriteLine("Nome do Aluno: ");
    aluno.Nome = Console.ReadLine();
    Console.WriteLine("Matricula: ");
    aluno.Matricula = Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("ID do Curso: ");
    aluno.IDCurso = Convert.ToInt16(Console.ReadLine());
    alunos.Add(aluno);

}
else if (opcao == 4)
{
    
}
else if (opcao == 5)
{
    
}
else if (opcao == 6)
{
    
}

public class Cursos
{
    public string Nome { get; set; }
    public int ID { get; set; }
    public int CargaHoraria { get; set; }
    public float MediaTotal { get; set; }
}

public class Alunos
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
    public int IDCurso { get; set; }
    public float Media { get; set; }
}